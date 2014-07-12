using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamMessageGenerator
{
    public partial class Form1 : Form
    {
        public Model model { get; set; }


        public Form1()
        {
            InitializeComponent();
            this.model = new Model();
            this.rbtnFirstCharacter.Checked = false;
            this.rbtnFirstCharacter.Checked = true;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Form newForm = new Settings(this, this.model);
            newForm.Show();
            this.Hide();
        }

        private void rbtnFirstCharacter_CheckedChanged(object sender, EventArgs e)
        {
            this.model.messageConverter.FirstCharacterSwap = true;
            this.model.messageConverter.RandomCharacterSwap = false;
            this.model.messageConverter.LastCharacterSwap = false;
        }

        private void rbtnRandomCharacter_CheckedChanged(object sender, EventArgs e)
        {
            this.model.messageConverter.FirstCharacterSwap = false;
            this.model.messageConverter.RandomCharacterSwap = true;
            this.model.messageConverter.LastCharacterSwap = false;
        }

        private void rbtnLastCharacter_CheckedChanged(object sender, EventArgs e)
        {
            this.model.messageConverter.FirstCharacterSwap = false;
            this.model.messageConverter.RandomCharacterSwap = false;
            this.model.messageConverter.LastCharacterSwap = true;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            this.rtbxGeneratedMessage.Text = this.model.messageConverter.ConvertMessage(this.rtbxMessage.Text);
        }

        private void tbxSpacesBetweenWords_TextChanged(object sender, EventArgs e)
        {
            int spacesBetweenWords = 3;

            if (!Int32.TryParse(this.tbxSpacesBetweenWords.Text, out spacesBetweenWords))
            {
                //This means that what was entered was not a valid integer
                spacesBetweenWords = 3;
            }

            if (spacesBetweenWords > 30)
            {
                spacesBetweenWords = 30;
                this.tbxSpacesBetweenWords.Text = spacesBetweenWords.ToString();
            }

            string spaceString = String.Empty;

            for (int i = 0; i < spacesBetweenWords; i++)
            {
                spaceString += " ";
            }

            this.model.messageConverter.spacesBetweenWords = spaceString;
            this.lblSpacesBetweenWords.Text = "Spaces to add between words: " + spacesBetweenWords;
        }
    }
}
