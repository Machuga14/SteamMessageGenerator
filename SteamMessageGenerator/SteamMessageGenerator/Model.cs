using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamMessageGenerator
{
    public class Model
    {
        public Saver ApplicationSaver { get; set; }
        public MessageConverter messageConverter { get; set; }

        public Random Generator { get; set; }

        public Model()
        {
            this.Generator = new Random();
            this.ApplicationSaver = new Saver("SteamMessageGenerator");
            this.messageConverter = new MessageConverter(this);


        }

        public List<string> ConvertCSVToStringList(string data)
        {
            List<string> retList = new List<string>();

            string currentBuildString = String.Empty; //This is the current "loaded" string which gets added to the retlist split upon commas not inside quotes.
            bool isInQuotes = false;

            for (int i = 0; i < data.Length-1; i++)
            {
                if (data[i] == '"')
                {
                    if (data[i + 1] == '"')
                    {
                        //This means its a double quote, and does not toggle isInQuotes
                        //We should also add a single quote to the loaded string...
                        currentBuildString += '"';
                        i++;
                        continue;
                    }
                    else
                    {
                        //This means its a single quote, and DOES toggle isInQuotes
                        isInQuotes = !isInQuotes;
                        continue;
                    }
                }
                if (data[i] == ',' && !isInQuotes)
                {
                    //This means it is the end of the current "Cell"...
                    retList.Add(currentBuildString);
                    currentBuildString = String.Empty;
                    continue;
                }
                else
                {
                    //this means it is time to continue rendering the build string...
                    currentBuildString += data[i];
                }
            }

            retList.Add(currentBuildString);

            return retList;
        }

        /// <summary>
        /// Converts a string to a CSV String... Adds a Quote to the beginning, and to the end
        /// And doubles up the quotes in the middle. THIS IS MEANT FOR A SINGLE CELL, SO INSERT STRINGS ONE CELL AT A TIME!!!
        /// THIS DOES NOT ADD COMMAS
        /// </summary>
        /// <param name="data">The string data to be converted</param>
        /// <returns>The Converted CSV String</returns>
        public string ConvertStringToCSVCell(string data)
        {
            string convertedString = "\"";

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == '"')
                {
                    convertedString += '"';
                }
                convertedString += data[i];
            }

            return convertedString + "\"";
        }

        public void Save()
        {
            this.messageConverter.Save();
        }
    }
}
