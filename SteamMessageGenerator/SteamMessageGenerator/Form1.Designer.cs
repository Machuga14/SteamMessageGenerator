namespace SteamMessageGenerator
{
    partial class Form1
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
            this.rtbxMessage = new System.Windows.Forms.RichTextBox();
            this.lblTypeMessageHere = new System.Windows.Forms.Label();
            this.rtbxGeneratedMessage = new System.Windows.Forms.RichTextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.rbtnFirstCharacter = new System.Windows.Forms.RadioButton();
            this.rbtnRandomCharacter = new System.Windows.Forms.RadioButton();
            this.rbtnLastCharacter = new System.Windows.Forms.RadioButton();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbxMessage
            // 
            this.rtbxMessage.AcceptsTab = true;
            this.rtbxMessage.Location = new System.Drawing.Point(16, 29);
            this.rtbxMessage.Name = "rtbxMessage";
            this.rtbxMessage.Size = new System.Drawing.Size(493, 258);
            this.rtbxMessage.TabIndex = 0;
            this.rtbxMessage.Text = "";
            // 
            // lblTypeMessageHere
            // 
            this.lblTypeMessageHere.AutoSize = true;
            this.lblTypeMessageHere.Location = new System.Drawing.Point(13, 13);
            this.lblTypeMessageHere.Name = "lblTypeMessageHere";
            this.lblTypeMessageHere.Size = new System.Drawing.Size(126, 13);
            this.lblTypeMessageHere.TabIndex = 1;
            this.lblTypeMessageHere.Text = "Type your message here!";
            // 
            // rtbxGeneratedMessage
            // 
            this.rtbxGeneratedMessage.AcceptsTab = true;
            this.rtbxGeneratedMessage.Location = new System.Drawing.Point(16, 332);
            this.rtbxGeneratedMessage.Name = "rtbxGeneratedMessage";
            this.rtbxGeneratedMessage.ReadOnly = true;
            this.rtbxGeneratedMessage.Size = new System.Drawing.Size(493, 243);
            this.rtbxGeneratedMessage.TabIndex = 2;
            this.rtbxGeneratedMessage.Text = "";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnGenerate.Location = new System.Drawing.Point(670, 229);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(139, 58);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // rbtnFirstCharacter
            // 
            this.rbtnFirstCharacter.AutoSize = true;
            this.rbtnFirstCharacter.Checked = true;
            this.rbtnFirstCharacter.Location = new System.Drawing.Point(601, 30);
            this.rbtnFirstCharacter.Name = "rbtnFirstCharacter";
            this.rbtnFirstCharacter.Size = new System.Drawing.Size(93, 17);
            this.rbtnFirstCharacter.TabIndex = 4;
            this.rbtnFirstCharacter.TabStop = true;
            this.rbtnFirstCharacter.Text = "First Character";
            this.rbtnFirstCharacter.UseVisualStyleBackColor = true;
            this.rbtnFirstCharacter.CheckedChanged += new System.EventHandler(this.rbtnFirstCharacter_CheckedChanged);
            // 
            // rbtnRandomCharacter
            // 
            this.rbtnRandomCharacter.AutoSize = true;
            this.rbtnRandomCharacter.Location = new System.Drawing.Point(601, 53);
            this.rbtnRandomCharacter.Name = "rbtnRandomCharacter";
            this.rbtnRandomCharacter.Size = new System.Drawing.Size(114, 17);
            this.rbtnRandomCharacter.TabIndex = 5;
            this.rbtnRandomCharacter.Text = "Random Character";
            this.rbtnRandomCharacter.UseVisualStyleBackColor = true;
            this.rbtnRandomCharacter.CheckedChanged += new System.EventHandler(this.rbtnRandomCharacter_CheckedChanged);
            // 
            // rbtnLastCharacter
            // 
            this.rbtnLastCharacter.AutoSize = true;
            this.rbtnLastCharacter.Location = new System.Drawing.Point(601, 76);
            this.rbtnLastCharacter.Name = "rbtnLastCharacter";
            this.rbtnLastCharacter.Size = new System.Drawing.Size(94, 17);
            this.rbtnLastCharacter.TabIndex = 6;
            this.rbtnLastCharacter.Text = "Last Character";
            this.rbtnLastCharacter.UseVisualStyleBackColor = true;
            this.rbtnLastCharacter.CheckedChanged += new System.EventHandler(this.rbtnLastCharacter_CheckedChanged);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(704, 515);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(105, 60);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 587);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.rbtnLastCharacter);
            this.Controls.Add(this.rbtnRandomCharacter);
            this.Controls.Add(this.rbtnFirstCharacter);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.rtbxGeneratedMessage);
            this.Controls.Add(this.lblTypeMessageHere);
            this.Controls.Add(this.rtbxMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbxMessage;
        private System.Windows.Forms.Label lblTypeMessageHere;
        private System.Windows.Forms.RichTextBox rtbxGeneratedMessage;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RadioButton rbtnFirstCharacter;
        private System.Windows.Forms.RadioButton rbtnRandomCharacter;
        private System.Windows.Forms.RadioButton rbtnLastCharacter;
        private System.Windows.Forms.Button btnSettings;
    }
}

