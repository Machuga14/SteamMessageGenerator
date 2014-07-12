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
    public partial class Settings : Form
    {
        public Form parent { get; set; }
        public Model model {get;set;}

        private bool isModifying = false;
        private AssociatedLetter ModifyingLetter = null;
        private int modifyingLetterIndex = -1;
        
        public Settings(Form parent, Model model)
        {
            InitializeComponent();
            this.parent = parent;
            this.model = model;
            this.RefreshMainListView();
        }

        public void RefreshMainListView()
        {
            this.lvAssociatedCharacters.Items.Clear();

            for (int i = 0; i < this.model.messageConverter.AssociatedLetters.Count(); i++)
            {
                ListViewItem item = new ListViewItem(this.model.messageConverter.AssociatedLetters[i].Character.ToString());
                this.lvAssociatedCharacters.Items.Add(item);
            }
        }

        public void RefreshSecondaryListView()
        {
            if (ModifyingLetter == null)
                return;

            this.lvAddNewCharacterPhraseLinkList.Items.Clear();
            this.tbxCharacter.Text = ModifyingLetter.Character.ToString();
            this.cbxIsCaseSensitive.Checked = ModifyingLetter.IsCaseSensitive;

            for (int i = 0; i < this.ModifyingLetter.AssociatedStrings.Count(); i++)
            {
                ListViewItem newItem = new ListViewItem(this.ModifyingLetter.AssociatedStrings[i]);
                newItem.SubItems.Add(this.ModifyingLetter.AssociatedStringLinks[i]);
                this.lvAddNewCharacterPhraseLinkList.Items.Add(newItem);
            }
        }

        private int GetSelectedIndexFromMainListview()
        {
            for (int i = 0; i < this.lvAssociatedCharacters.Items.Count; i++)
            {
                if (this.lvAssociatedCharacters.Items[i].Selected)
                    return i;
            }
            return -1;
        }

        private int GetSelectedIndexFromSecondaryListview()
        {
            for (int i = 0; i < this.lvAddNewCharacterPhraseLinkList.Items.Count; i++)
            {
                if (this.lvAddNewCharacterPhraseLinkList.Items[i].Selected)
                    return i;
            }
            return -1;
        }

        private void SetForCreatingNew(bool isCreatingNew)
        {
            if (isCreatingNew)
            {
                this.gpboxAddOrModifyNewCharacter.Visible = true;
                this.btnAdd.Enabled = true;
                this.btnUpdate.Enabled = false;
                this.btnNew.Enabled = false;
                this.btnDelete.Enabled = false;
                this.btnNew.Enabled = false;
            }
            else
            {
                this.gpboxAddOrModifyNewCharacter.Visible = false;
                this.btnNew.Enabled = true;
                this.btnCancel.Enabled = true;
                this.btnModify.Enabled = true;
                this.btnDelete.Enabled = true;
            }
        }

        private void SetForModifying(bool isModifying)
        {
            if (isModifying)
            {
                this.gpboxAddOrModifyNewCharacter.Visible = true;
                this.btnAdd.Enabled = false;
                this.btnModify.Enabled = false;
                this.btnUpdate.Enabled = true;
                this.btnNew.Enabled = false;
                this.btnDelete.Enabled = false;
                this.isModifying = true;
                this.modifyingLetterIndex = this.GetSelectedIndexFromMainListview();
            }
            else
            {
                this.gpboxAddOrModifyNewCharacter.Visible = false;
                this.btnNew.Enabled = true;
                this.btnCancel.Enabled = true;
                this.btnModify.Enabled = true;
                this.btnDelete.Enabled = true;
                this.isModifying = false;
                this.modifyingLetterIndex = -1;
            }
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.model.Save();
            this.parent.Show();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.SetForCreatingNew(true);
            this.ModifyingLetter = new AssociatedLetter(' ',this.model);
            this.tbxCharacter.Select();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            int index = this.GetSelectedIndexFromMainListview();
            if (index == -1)
            {
                MessageBox.Show("Please select something to modify!");
                return;
            }
            this.ModifyingLetter = new AssociatedLetter(this.model.messageConverter.AssociatedLetters[index]);
            this.isModifying = true;
            this.SetForModifying(true);
            this.RefreshSecondaryListView();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (btnAdd.Enabled)
                this.SetForCreatingNew(false);
            else
                this.SetForModifying(false);
            this.ModifyingLetter = null;
        }

        private void tbxCharacter_TextChanged(object sender, EventArgs e)
        {
            if (this.tbxCharacter.Text.Length == 2)
            {
                this.tbxCharacter.Text = this.tbxCharacter.Text[1].ToString();
                this.tbxCharacter.Select();
                this.tbxCharacter.Select(1, 0);
            }
            if (this.ModifyingLetter != null)
                this.ModifyingLetter.Character = this.tbxCharacter.Text.Length > 0 ? this.tbxCharacter.Text[0] : ' ';
        }

        private void btnAddPhraseLink_Click(object sender, EventArgs e)
        {
            this.ModifyingLetter.AssociatedStrings.Add(this.tbxPhrase.Text);
            this.ModifyingLetter.AssociatedStringLinks.Add(this.rtbxLink.Text);
            this.RefreshSecondaryListView();
            this.tbxPhrase.Select();
            this.tbxPhrase.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.model.messageConverter.AssociatedLetters.Add(ModifyingLetter);
            this.ModifyingLetter = null;
            this.SetForCreatingNew(false);

            this.model.messageConverter.AssociatedLetters.Sort();

            this.tbxCharacter.Text = String.Empty;
            this.rtbxLink.Text = String.Empty;
            this.tbxPhrase.Text = String.Empty;
            this.lvAddNewCharacterPhraseLinkList.Items.Clear();
            this.RefreshMainListView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.model.messageConverter.AssociatedLetters[modifyingLetterIndex] = new AssociatedLetter(this.ModifyingLetter);
            this.ModifyingLetter = null;
            this.SetForModifying(false);

            this.model.messageConverter.AssociatedLetters.Sort();

            this.tbxCharacter.Text = String.Empty;
            this.rtbxLink.Text = String.Empty;
            this.tbxPhrase.Text = String.Empty;
            this.lvAddNewCharacterPhraseLinkList.Items.Clear();
            this.RefreshMainListView();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = this.ModifyingLetter == null ? "NULL" : this.ModifyingLetter.ToString();
        }

        private void lvAssociatedCharacters_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!this.gpboxAddOrModifyNewCharacter.Visible)
                this.btnModify_Click(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = this.GetSelectedIndexFromMainListview();

            if (index == -1)
            {
                MessageBox.Show("Please Select a character to delete.");
                return;
            }

            this.model.messageConverter.AssociatedLetters.RemoveAt(index);
            this.RefreshMainListView();
        }

        private void lvAssociatedCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDeletePhraseLink_Click(object sender, EventArgs e)
        {
            int index = this.GetSelectedIndexFromSecondaryListview();

            if (index == -1)
            {
                MessageBox.Show("Please Select a Phrase / Link To delete!");
                return;
            }

            this.ModifyingLetter.AssociatedStringLinks.RemoveAt(index);
            this.ModifyingLetter.AssociatedStrings.RemoveAt(index);
            this.RefreshSecondaryListView();
        }

        private void btnMovePhraseLinkUp_Click(object sender, EventArgs e)
        {
            int index = this.GetSelectedIndexFromSecondaryListview();

            if (index == -1)
            {
                MessageBox.Show("Please Select a Phrase/Link before attempting to move it up!");
                return;
            }

            if (index == 0)
            {
                this.lvAddNewCharacterPhraseLinkList.Select();
                this.lvAddNewCharacterPhraseLinkList.Items[index].Selected = true;
                return;
            }

            string phrase = ModifyingLetter.AssociatedStrings[index];
            string link = ModifyingLetter.AssociatedStringLinks[index];

            ModifyingLetter.AssociatedStrings.RemoveAt(index);
            ModifyingLetter.AssociatedStringLinks.RemoveAt(index);

            ModifyingLetter.AssociatedStrings.Insert(index - 1, phrase);
            ModifyingLetter.AssociatedStringLinks.Insert(index - 1, link);
            this.RefreshSecondaryListView(); 
            this.lvAddNewCharacterPhraseLinkList.Select();
            this.lvAddNewCharacterPhraseLinkList.Items[index - 1].Selected = true;
        }

        private void btnMovePhraseLinkDown_Click(object sender, EventArgs e)
        {
            int index = this.GetSelectedIndexFromSecondaryListview();

            if (index == -1)
            {
                MessageBox.Show("Please Select a Phrase/Link before attempting to move it down!");
                return;
            }

            if (index == this.ModifyingLetter.AssociatedStringLinks.Count() - 1)
            {
                this.lvAddNewCharacterPhraseLinkList.Select();
                this.lvAddNewCharacterPhraseLinkList.Items[index].Selected = true;
                return;
            }

            string phrase = ModifyingLetter.AssociatedStrings[index];
            string link = ModifyingLetter.AssociatedStringLinks[index];

            ModifyingLetter.AssociatedStrings.RemoveAt(index);
            ModifyingLetter.AssociatedStringLinks.RemoveAt(index);

            ModifyingLetter.AssociatedStrings.Insert(index + 1, phrase);
            ModifyingLetter.AssociatedStringLinks.Insert(index + 1, link);
            this.RefreshSecondaryListView();
            this.lvAddNewCharacterPhraseLinkList.Select();
            this.lvAddNewCharacterPhraseLinkList.Items[index + 1].Selected = true;
        }

        private void cbxIsCaseSensitive_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ModifyingLetter != null)
            {
                this.ModifyingLetter.IsCaseSensitive = this.cbxIsCaseSensitive.Checked;
            }
        }
    }
}
