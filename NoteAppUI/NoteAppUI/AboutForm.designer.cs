
namespace NoteAppUI
{
    partial class AboutForm
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
            this.AboutLabelTitle = new System.Windows.Forms.Label();
            this.AboutLabelVersion = new System.Windows.Forms.Label();
            this.AboutLabelAutor = new System.Windows.Forms.Label();
            this.AboutLabelEmail = new System.Windows.Forms.Label();
            this.AboutLabelGit = new System.Windows.Forms.Label();
            this.AboutLabelYear = new System.Windows.Forms.Label();
            this.AboutGitLinkLabel = new System.Windows.Forms.LinkLabel();
            this.EmailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // AboutLabelTitle
            // 
            this.AboutLabelTitle.AutoSize = true;
            this.AboutLabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutLabelTitle.Location = new System.Drawing.Point(12, 20);
            this.AboutLabelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AboutLabelTitle.Name = "AboutLabelTitle";
            this.AboutLabelTitle.Size = new System.Drawing.Size(132, 32);
            this.AboutLabelTitle.TabIndex = 0;
            this.AboutLabelTitle.Text = "NoteApp";
            // 
            // AboutLabelVersion
            // 
            this.AboutLabelVersion.AutoSize = true;
            this.AboutLabelVersion.Location = new System.Drawing.Point(15, 63);
            this.AboutLabelVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AboutLabelVersion.Name = "AboutLabelVersion";
            this.AboutLabelVersion.Size = new System.Drawing.Size(47, 16);
            this.AboutLabelVersion.TabIndex = 1;
            this.AboutLabelVersion.Text = "v. 1.0.0";
            // 
            // AboutLabelAutor
            // 
            this.AboutLabelAutor.AutoSize = true;
            this.AboutLabelAutor.Location = new System.Drawing.Point(25, 100);
            this.AboutLabelAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AboutLabelAutor.Name = "AboutLabelAutor";
            this.AboutLabelAutor.Size = new System.Drawing.Size(162, 16);
            this.AboutLabelAutor.TabIndex = 2;
            this.AboutLabelAutor.Text = "Author: Menshikov Andrey";
            // 
            // AboutLabelEmail
            // 
            this.AboutLabelEmail.AutoSize = true;
            this.AboutLabelEmail.Location = new System.Drawing.Point(25, 130);
            this.AboutLabelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AboutLabelEmail.Name = "AboutLabelEmail";
            this.AboutLabelEmail.Size = new System.Drawing.Size(51, 16);
            this.AboutLabelEmail.TabIndex = 3;
            this.AboutLabelEmail.Text = "E-mail: ";
            // 
            // AboutLabelGit
            // 
            this.AboutLabelGit.AutoSize = true;
            this.AboutLabelGit.Location = new System.Drawing.Point(25, 160);
            this.AboutLabelGit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AboutLabelGit.Name = "AboutLabelGit";
            this.AboutLabelGit.Size = new System.Drawing.Size(51, 16);
            this.AboutLabelGit.TabIndex = 4;
            this.AboutLabelGit.Text = "Github: ";
            // 
            // AboutLabelYear
            // 
            this.AboutLabelYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AboutLabelYear.AutoSize = true;
            this.AboutLabelYear.Location = new System.Drawing.Point(15, 325);
            this.AboutLabelYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AboutLabelYear.Name = "AboutLabelYear";
            this.AboutLabelYear.Size = new System.Drawing.Size(160, 16);
            this.AboutLabelYear.TabIndex = 5;
            this.AboutLabelYear.Text = "2021 Menshikov Andrey ©";
            // 
            // AboutGitLinkLabel
            // 
            this.AboutGitLinkLabel.AutoSize = true;
            this.AboutGitLinkLabel.Location = new System.Drawing.Point(78, 160);
            this.AboutGitLinkLabel.Name = "AboutGitLinkLabel";
            this.AboutGitLinkLabel.Size = new System.Drawing.Size(212, 16);
            this.AboutGitLinkLabel.TabIndex = 6;
            this.AboutGitLinkLabel.TabStop = true;
            this.AboutGitLinkLabel.Text = "github.com/godzzzzzz1la/NoteApp";
            this.AboutGitLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AboutGitLinkLabel_LinkClicked);
            // 
            // EmailLinkLabel
            // 
            this.EmailLinkLabel.AutoSize = true;
            this.EmailLinkLabel.Location = new System.Drawing.Point(81, 129);
            this.EmailLinkLabel.Name = "EmailLinkLabel";
            this.EmailLinkLabel.Size = new System.Drawing.Size(180, 16);
            this.EmailLinkLabel.TabIndex = 7;
            this.EmailLinkLabel.TabStop = true;
            this.EmailLinkLabel.Text = "a.menshikov011@gmail.com";
            this.EmailLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EmailLinkLabel_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(490, 352);
            this.Controls.Add(this.EmailLinkLabel);
            this.Controls.Add(this.AboutGitLinkLabel);
            this.Controls.Add(this.AboutLabelYear);
            this.Controls.Add(this.AboutLabelGit);
            this.Controls.Add(this.AboutLabelEmail);
            this.Controls.Add(this.AboutLabelAutor);
            this.Controls.Add(this.AboutLabelVersion);
            this.Controls.Add(this.AboutLabelTitle);
            this.MaximumSize = new System.Drawing.Size(508, 399);
            this.MinimumSize = new System.Drawing.Size(508, 399);
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAQ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AboutLabelTitle;
        private System.Windows.Forms.Label AboutLabelVersion;
        private System.Windows.Forms.Label AboutLabelAutor;
        private System.Windows.Forms.Label AboutLabelEmail;
        private System.Windows.Forms.Label AboutLabelGit;
        private System.Windows.Forms.Label AboutLabelYear;
        private System.Windows.Forms.LinkLabel AboutGitLinkLabel;
        private System.Windows.Forms.LinkLabel EmailLinkLabel;
    }
}