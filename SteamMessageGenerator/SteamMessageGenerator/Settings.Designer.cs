namespace SteamMessageGenerator
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lvAssociatedCharacters = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpboxAddOrModifyNewCharacter = new System.Windows.Forms.GroupBox();
            this.btnMovePhraseLinkDown = new System.Windows.Forms.Button();
            this.btnMovePhraseLinkUp = new System.Windows.Forms.Button();
            this.btnDeletePhraseLink = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddPhraseLink = new System.Windows.Forms.Button();
            this.rtbxLink = new System.Windows.Forms.RichTextBox();
            this.lblLink = new System.Windows.Forms.Label();
            this.lblPhrase = new System.Windows.Forms.Label();
            this.tbxPhrase = new System.Windows.Forms.TextBox();
            this.lvAddNewCharacterPhraseLinkList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbxCharacter = new System.Windows.Forms.TextBox();
            this.lblCharacter = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbxIsCaseSensitive = new System.Windows.Forms.CheckBox();
            this.gpboxAddOrModifyNewCharacter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvAssociatedCharacters
            // 
            this.lvAssociatedCharacters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvAssociatedCharacters.FullRowSelect = true;
            this.lvAssociatedCharacters.Location = new System.Drawing.Point(13, 13);
            this.lvAssociatedCharacters.Name = "lvAssociatedCharacters";
            this.lvAssociatedCharacters.Size = new System.Drawing.Size(75, 536);
            this.lvAssociatedCharacters.TabIndex = 0;
            this.lvAssociatedCharacters.UseCompatibleStateImageBehavior = false;
            this.lvAssociatedCharacters.View = System.Windows.Forms.View.Details;
            this.lvAssociatedCharacters.SelectedIndexChanged += new System.EventHandler(this.lvAssociatedCharacters_SelectedIndexChanged);
            this.lvAssociatedCharacters.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvAssociatedCharacters_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Character";
            // 
            // gpboxAddOrModifyNewCharacter
            // 
            this.gpboxAddOrModifyNewCharacter.Controls.Add(this.cbxIsCaseSensitive);
            this.gpboxAddOrModifyNewCharacter.Controls.Add(this.btnMovePhraseLinkDown);
            this.gpboxAddOrModifyNewCharacter.Controls.Add(this.btnMovePhraseLinkUp);
            this.gpboxAddOrModifyNewCharacter.Controls.Add(this.btnDeletePhraseLink);
            this.gpboxAddOrModifyNewCharacter.Controls.Add(this.btnCancel);
            this.gpboxAddOrModifyNewCharacter.Controls.Add(this.btnUpdate);
            this.gpboxAddOrModifyNewCharacter.Controls.Add(this.btnAdd);
            this.gpboxAddOrModifyNewCharacter.Controls.Add(this.btnAddPhraseLink);
            this.gpboxAddOrModifyNewCharacter.Controls.Add(this.rtbxLink);
            this.gpboxAddOrModifyNewCharacter.Controls.Add(this.lblLink);
            this.gpboxAddOrModifyNewCharacter.Controls.Add(this.lblPhrase);
            this.gpboxAddOrModifyNewCharacter.Controls.Add(this.tbxPhrase);
            this.gpboxAddOrModifyNewCharacter.Controls.Add(this.lvAddNewCharacterPhraseLinkList);
            this.gpboxAddOrModifyNewCharacter.Controls.Add(this.tbxCharacter);
            this.gpboxAddOrModifyNewCharacter.Controls.Add(this.lblCharacter);
            this.gpboxAddOrModifyNewCharacter.Location = new System.Drawing.Point(397, 12);
            this.gpboxAddOrModifyNewCharacter.Name = "gpboxAddOrModifyNewCharacter";
            this.gpboxAddOrModifyNewCharacter.Size = new System.Drawing.Size(463, 536);
            this.gpboxAddOrModifyNewCharacter.TabIndex = 1;
            this.gpboxAddOrModifyNewCharacter.TabStop = false;
            this.gpboxAddOrModifyNewCharacter.Text = "Add New Character Or Modify Old one";
            this.gpboxAddOrModifyNewCharacter.Visible = false;
            // 
            // btnMovePhraseLinkDown
            // 
            this.btnMovePhraseLinkDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F);
            this.btnMovePhraseLinkDown.Location = new System.Drawing.Point(407, 237);
            this.btnMovePhraseLinkDown.Name = "btnMovePhraseLinkDown";
            this.btnMovePhraseLinkDown.Size = new System.Drawing.Size(56, 180);
            this.btnMovePhraseLinkDown.TabIndex = 14;
            this.btnMovePhraseLinkDown.Text = "↓";
            this.btnMovePhraseLinkDown.UseVisualStyleBackColor = true;
            this.btnMovePhraseLinkDown.Click += new System.EventHandler(this.btnMovePhraseLinkDown_Click);
            // 
            // btnMovePhraseLinkUp
            // 
            this.btnMovePhraseLinkUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F);
            this.btnMovePhraseLinkUp.Location = new System.Drawing.Point(406, 51);
            this.btnMovePhraseLinkUp.Name = "btnMovePhraseLinkUp";
            this.btnMovePhraseLinkUp.Size = new System.Drawing.Size(56, 180);
            this.btnMovePhraseLinkUp.TabIndex = 13;
            this.btnMovePhraseLinkUp.Text = "↑";
            this.btnMovePhraseLinkUp.UseVisualStyleBackColor = true;
            this.btnMovePhraseLinkUp.Click += new System.EventHandler(this.btnMovePhraseLinkUp_Click);
            // 
            // btnDeletePhraseLink
            // 
            this.btnDeletePhraseLink.Location = new System.Drawing.Point(265, 508);
            this.btnDeletePhraseLink.Name = "btnDeletePhraseLink";
            this.btnDeletePhraseLink.Size = new System.Drawing.Size(135, 23);
            this.btnDeletePhraseLink.TabIndex = 12;
            this.btnDeletePhraseLink.Text = "Delete Phrase / Link";
            this.btnDeletePhraseLink.UseVisualStyleBackColor = true;
            this.btnDeletePhraseLink.Click += new System.EventHandler(this.btnDeletePhraseLink_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(92, 508);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(10, 508);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 478);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddPhraseLink
            // 
            this.btnAddPhraseLink.Location = new System.Drawing.Point(112, 478);
            this.btnAddPhraseLink.Name = "btnAddPhraseLink";
            this.btnAddPhraseLink.Size = new System.Drawing.Size(288, 23);
            this.btnAddPhraseLink.TabIndex = 8;
            this.btnAddPhraseLink.Text = "Add Phrase / Link";
            this.btnAddPhraseLink.UseVisualStyleBackColor = true;
            this.btnAddPhraseLink.Click += new System.EventHandler(this.btnAddPhraseLink_Click);
            // 
            // rtbxLink
            // 
            this.rtbxLink.Location = new System.Drawing.Point(209, 452);
            this.rtbxLink.Multiline = false;
            this.rtbxLink.Name = "rtbxLink";
            this.rtbxLink.Size = new System.Drawing.Size(191, 20);
            this.rtbxLink.TabIndex = 7;
            this.rtbxLink.Text = "";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(206, 433);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(27, 13);
            this.lblLink.TabIndex = 6;
            this.lblLink.Text = "Link";
            // 
            // lblPhrase
            // 
            this.lblPhrase.AutoSize = true;
            this.lblPhrase.Location = new System.Drawing.Point(112, 433);
            this.lblPhrase.Name = "lblPhrase";
            this.lblPhrase.Size = new System.Drawing.Size(40, 13);
            this.lblPhrase.TabIndex = 5;
            this.lblPhrase.Text = "Phrase";
            // 
            // tbxPhrase
            // 
            this.tbxPhrase.Location = new System.Drawing.Point(112, 452);
            this.tbxPhrase.Name = "tbxPhrase";
            this.tbxPhrase.Size = new System.Drawing.Size(87, 20);
            this.tbxPhrase.TabIndex = 3;
            // 
            // lvAddNewCharacterPhraseLinkList
            // 
            this.lvAddNewCharacterPhraseLinkList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.lvAddNewCharacterPhraseLinkList.FullRowSelect = true;
            this.lvAddNewCharacterPhraseLinkList.Location = new System.Drawing.Point(112, 19);
            this.lvAddNewCharacterPhraseLinkList.Name = "lvAddNewCharacterPhraseLinkList";
            this.lvAddNewCharacterPhraseLinkList.Size = new System.Drawing.Size(288, 398);
            this.lvAddNewCharacterPhraseLinkList.TabIndex = 2;
            this.lvAddNewCharacterPhraseLinkList.UseCompatibleStateImageBehavior = false;
            this.lvAddNewCharacterPhraseLinkList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Phrase";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Link";
            this.columnHeader3.Width = 197;
            // 
            // tbxCharacter
            // 
            this.tbxCharacter.Location = new System.Drawing.Point(10, 37);
            this.tbxCharacter.MaxLength = 2;
            this.tbxCharacter.Name = "tbxCharacter";
            this.tbxCharacter.Size = new System.Drawing.Size(34, 20);
            this.tbxCharacter.TabIndex = 1;
            this.tbxCharacter.TextChanged += new System.EventHandler(this.tbxCharacter_TextChanged);
            // 
            // lblCharacter
            // 
            this.lblCharacter.AutoSize = true;
            this.lblCharacter.Location = new System.Drawing.Point(7, 20);
            this.lblCharacter.Name = "lblCharacter";
            this.lblCharacter.Size = new System.Drawing.Size(53, 13);
            this.lblCharacter.TabIndex = 0;
            this.lblCharacter.Text = "Character";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(94, 521);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(95, 492);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(201, 520);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbxIsCaseSensitive
            // 
            this.cbxIsCaseSensitive.AutoSize = true;
            this.cbxIsCaseSensitive.Location = new System.Drawing.Point(10, 154);
            this.cbxIsCaseSensitive.Name = "cbxIsCaseSensitive";
            this.cbxIsCaseSensitive.Size = new System.Drawing.Size(102, 17);
            this.cbxIsCaseSensitive.TabIndex = 15;
            this.cbxIsCaseSensitive.Text = "Case Sensitive?";
            this.cbxIsCaseSensitive.UseVisualStyleBackColor = true;
            this.cbxIsCaseSensitive.CheckedChanged += new System.EventHandler(this.cbxIsCaseSensitive_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 561);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.gpboxAddOrModifyNewCharacter);
            this.Controls.Add(this.lvAssociatedCharacters);
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.gpboxAddOrModifyNewCharacter.ResumeLayout(false);
            this.gpboxAddOrModifyNewCharacter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvAssociatedCharacters;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox gpboxAddOrModifyNewCharacter;
        private System.Windows.Forms.RichTextBox rtbxLink;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.Label lblPhrase;
        private System.Windows.Forms.TextBox tbxPhrase;
        private System.Windows.Forms.ListView lvAddNewCharacterPhraseLinkList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox tbxCharacter;
        private System.Windows.Forms.Label lblCharacter;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddPhraseLink;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDeletePhraseLink;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnMovePhraseLinkDown;
        private System.Windows.Forms.Button btnMovePhraseLinkUp;
        private System.Windows.Forms.CheckBox cbxIsCaseSensitive;
    }
}