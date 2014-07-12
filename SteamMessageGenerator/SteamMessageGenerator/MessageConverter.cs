using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamMessageGenerator
{
    public class MessageConverter
    {
        public Model model { get; set; }

        public List<AssociatedLetter> AssociatedLetters { get; set; }

        public bool FirstCharacterSwap { get; set; }
        public bool RandomCharacterSwap { get; set; }
        public bool LastCharacterSwap { get; set; }

        public string spacesBetweenWords { get; set; }

        public MessageConverter(Model model)
        {
            this.model = model;
            this.AssociatedLetters = new List<AssociatedLetter>();
            this.spacesBetweenWords = "   ";
            this.Load();
        }

        public string ConvertMessage(string message)
        {
            string retString = String.Empty;

            this.AssociatedLetters.Sort();

            for (int i = 0; i < message.Count(); i++)
            {
                retString += grabSubstitution(message[i]);
            }

            return retString;
        }

        private string grabSubstitution(char c)
        {
            string retString = c.ToString();

            if (c == ' ')
                retString += this.spacesBetweenWords;

            for (int i = 0; i < this.AssociatedLetters.Count(); i++)
            {
                //This means theres a matching character regardless of case
                if (c.ToString().ToUpper() == this.AssociatedLetters[i].Character.ToString().ToUpper())
                {
                    if (!this.AssociatedLetters[i].IsCaseSensitive || c == this.AssociatedLetters[i].Character)
                    {
                        //This means that the character either matches EXACTLY, or is not case sensitive...
                        if (this.FirstCharacterSwap)
                        {
                            retString = this.AssociatedLetters[i].AssociatedStrings.Count() > 0 ? this.AssociatedLetters[i].AssociatedStrings[0] : c.ToString();
                        }
                        else if (this.RandomCharacterSwap)
                        {
                            int index = this.AssociatedLetters[i].AssociatedStrings.Count() > 0 ? this.model.Generator.Next(this.AssociatedLetters[i].AssociatedStrings.Count()) : 0;
                            retString = this.AssociatedLetters[i].AssociatedStrings.Count() > 0 ? this.AssociatedLetters[i].AssociatedStrings[index] : c.ToString();
                        }
                        else if (this.LastCharacterSwap)
                        {
                            int index = this.AssociatedLetters[i].AssociatedStrings.Count() > 0 ?this.AssociatedLetters[i].AssociatedStrings.Count()-1 : 0;
                            retString = this.AssociatedLetters[i].AssociatedStrings.Count() > 0 ? this.AssociatedLetters[i].AssociatedStrings[index] : c.ToString();
                        }
                    }
                }
            }

            return retString;
        }

        public void Load()
        {
            this.AssociatedLetters = new List<AssociatedLetter>();

            List<string> LinesOfData = this.model.ApplicationSaver.LoadAsListOfString("LetterData.dat", "");

            for (int i = 0; i < LinesOfData.Count(); i++)
            {
                if (LinesOfData[i] != null)
                    this.AssociatedLetters.Add(new AssociatedLetter(LinesOfData[i], model));
            }
        }

        public void Save()
        {
            this.model.ApplicationSaver.Save(this.ToString(), "LetterData.dat", "");
        }

        public override string ToString()
        {
            string retString = String.Empty;

            retString += this.AssociatedLetters.Count() > 0 ? this.AssociatedLetters[0].ToString() : String.Empty;

            for (int i = 1; i < this.AssociatedLetters.Count(); i++)
            {
                retString += "\r\n" + this.AssociatedLetters[i].ToString();
            }

            return retString;
        }
    }

    public class AssociatedLetter : IComparable<AssociatedLetter>, IComparer<AssociatedLetter>
    {
        public char Character { get; set; }

        public bool IsCaseSensitive { get; set; }

        public List<string> AssociatedStrings { get; set; }
        public List<string> AssociatedStringLinks { get; set; }

        public Model model { get; set; }

        public AssociatedLetter(char Letter, Model model)
        {
            this.Character = Letter;
            this.AssociatedStrings = new List<string>();
            this.AssociatedStringLinks = new List<string>();
            this.model = model;
            this.IsCaseSensitive = false;
        }

        public AssociatedLetter(string data, Model model)
        {
            this.AssociatedStrings = new List<string>();
            this.AssociatedStringLinks = new List<string>();
            this.model = model;
            this.IsCaseSensitive = false;
            this.Load(data);
        }

        /// <summary>
        /// Creates a hard copy of an associated letter
        /// </summary>
        /// <param name="?"></param>
        public AssociatedLetter(AssociatedLetter letter)
        {
            this.Character = letter.Character;
            this.IsCaseSensitive = letter.IsCaseSensitive;
            this.model = letter.model;

            this.AssociatedStrings = new List<string>();
            this.AssociatedStringLinks = new List<string>();

            for (int i = 0; i < letter.AssociatedStrings.Count(); i++)
            {
                this.AssociatedStrings.Add(letter.AssociatedStrings[i]);
                this.AssociatedStringLinks.Add(letter.AssociatedStringLinks[i]);
            }
        }

        public void Load(string data)
        {
            List<string> convertedData = this.model.ConvertCSVToStringList(data);

            //This mans that the data is not an odd length, and therefore was corrupted somehow...
            if (convertedData.Count() % 2 != 0 || convertedData.Count() == 0)
            {
                this.Character = convertedData.Count() > 0 ? convertedData[0][0] : '☺';
                this.AssociatedStrings = new List<string>() {"CORRUPTED DATA! The Steam keyphrase Goes here!"};
                this.AssociatedStringLinks = new List<string>() {"CORRUPTED DATA! The Steam Link Goes here!"};
                return;
            }

            //This means that the letter cannot be loaded...
            if (convertedData[0].Length == 0)
            {
                this.Character = '☻';
                return;
            }

            //This means that everything is good, lengthwise
            this.Character = convertedData[0][0];
            bool isCaseSensitive = false;
            Boolean.TryParse(convertedData[1], out isCaseSensitive);
            this.IsCaseSensitive = isCaseSensitive;

            for (int i = 2; i < convertedData.Count(); i += 2)
            {
                this.AssociatedStrings.Add(convertedData[i]);
                this.AssociatedStringLinks.Add(convertedData[i + 1]);
            }


        }

        public override string ToString()
        {
            string retString = String.Empty;

            retString += "\"" + this.Character + "\"";
            retString += ",\"" + this.IsCaseSensitive.ToString() + "\"";

            for (int i = 0; i < this.AssociatedStrings.Count(); i++)
            {
                retString += "," + this.model.ConvertStringToCSVCell(this.AssociatedStrings[i]);
                retString += "," + this.model.ConvertStringToCSVCell(this.AssociatedStringLinks[i]);
            }

            return retString;
        }

        public int CompareTo(AssociatedLetter other)
        {
            return this.Character.CompareTo(other.Character);
        }

        public int Compare(AssociatedLetter x, AssociatedLetter y)
        {
            return x.CompareTo(y);
        }
    }
}
