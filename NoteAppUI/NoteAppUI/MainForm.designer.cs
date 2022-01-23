
namespace NoteAppUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.СreateNewNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCurrentNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteCurrentNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutTheProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HeadNoteCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.TitleListBox = new System.Windows.Forms.ListBox();
            this.CreationDataTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ModifitionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TimeOfCreationLabel = new System.Windows.Forms.Label();
            this.TimeOfEditionLabel = new System.Windows.Forms.Label();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.ShowCategoryLabel = new System.Windows.Forms.Label();
            this.CreateNoteButton = new System.Windows.Forms.Button();
            this.EditNoteButton = new System.Windows.Forms.Button();
            this.DeleteNoteButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.fAQToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.ExitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.СreateNewNoteToolStripMenuItem,
            this.EditCurrentNoteToolStripMenuItem,
            this.DeleteCurrentNoteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // СreateNewNoteToolStripMenuItem
            // 
            this.СreateNewNoteToolStripMenuItem.Name = "СreateNewNoteToolStripMenuItem";
            this.СreateNewNoteToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.СreateNewNoteToolStripMenuItem.Text = "Create a new note";
            this.СreateNewNoteToolStripMenuItem.Click += new System.EventHandler(this.СreateNewNoteToolStripMenuItem_Click);
            // 
            // EditCurrentNoteToolStripMenuItem
            // 
            this.EditCurrentNoteToolStripMenuItem.Name = "EditCurrentNoteToolStripMenuItem";
            this.EditCurrentNoteToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.EditCurrentNoteToolStripMenuItem.Text = "Edit current note";
            this.EditCurrentNoteToolStripMenuItem.Click += new System.EventHandler(this.EditCurrentNoteToolStripMenuItem_Click);
            // 
            // DeleteCurrentNoteToolStripMenuItem
            // 
            this.DeleteCurrentNoteToolStripMenuItem.Name = "DeleteCurrentNoteToolStripMenuItem";
            this.DeleteCurrentNoteToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.DeleteCurrentNoteToolStripMenuItem.Text = "Delete current note";
            this.DeleteCurrentNoteToolStripMenuItem.Click += new System.EventHandler(this.DeleteCurrentNoteToolStripMenuItem_Click);
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutTheProgramToolStripMenuItem});
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.fAQToolStripMenuItem.Text = "Help";
            // 
            // AboutTheProgramToolStripMenuItem
            // 
            this.AboutTheProgramToolStripMenuItem.Name = "AboutTheProgramToolStripMenuItem";
            this.AboutTheProgramToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.AboutTheProgramToolStripMenuItem.Text = "About the program ";
            this.AboutTheProgramToolStripMenuItem.Click += new System.EventHandler(this.AboutTheProgramToolStripMenuItem_Click);
            // 
            // HeadNoteCategoryComboBox
            // 
            this.HeadNoteCategoryComboBox.FormattingEnabled = true;
            this.HeadNoteCategoryComboBox.Location = new System.Drawing.Point(131, 43);
            this.HeadNoteCategoryComboBox.Name = "HeadNoteCategoryComboBox";
            this.HeadNoteCategoryComboBox.Size = new System.Drawing.Size(166, 24);
            this.HeadNoteCategoryComboBox.TabIndex = 1;
            this.HeadNoteCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.HeadNoteCategoryComboBox_SelectedIndexChanged);
            // 
            // TitleListBox
            // 
            this.TitleListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TitleListBox.FormattingEnabled = true;
            this.TitleListBox.ItemHeight = 16;
            this.TitleListBox.Location = new System.Drawing.Point(12, 77);
            this.TitleListBox.Name = "TitleListBox";
            this.TitleListBox.Size = new System.Drawing.Size(286, 468);
            this.TitleListBox.TabIndex = 2;
            this.TitleListBox.SelectedIndexChanged += new System.EventHandler(this.NotesListBox_SelectedIndexChanged);
            // 
            // CreationDataTimePicker
            // 
            this.CreationDataTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CreationDataTimePicker.Location = new System.Drawing.Point(393, 99);
            this.CreationDataTimePicker.Name = "CreationDataTimePicker";
            this.CreationDataTimePicker.Size = new System.Drawing.Size(145, 22);
            this.CreationDataTimePicker.TabIndex = 7;
            // 
            // ModifitionDateTimePicker
            // 
            this.ModifitionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ModifitionDateTimePicker.Location = new System.Drawing.Point(648, 99);
            this.ModifitionDateTimePicker.Name = "ModifitionDateTimePicker";
            this.ModifitionDateTimePicker.Size = new System.Drawing.Size(147, 22);
            this.ModifitionDateTimePicker.TabIndex = 8;
            // 
            // TimeOfCreationLabel
            // 
            this.TimeOfCreationLabel.AutoSize = true;
            this.TimeOfCreationLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TimeOfCreationLabel.Location = new System.Drawing.Point(329, 105);
            this.TimeOfCreationLabel.Name = "TimeOfCreationLabel";
            this.TimeOfCreationLabel.Size = new System.Drawing.Size(58, 16);
            this.TimeOfCreationLabel.TabIndex = 9;
            this.TimeOfCreationLabel.Text = "Created:";
            // 
            // TimeOfEditionLabel
            // 
            this.TimeOfEditionLabel.AutoSize = true;
            this.TimeOfEditionLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TimeOfEditionLabel.Location = new System.Drawing.Point(580, 105);
            this.TimeOfEditionLabel.Name = "TimeOfEditionLabel";
            this.TimeOfEditionLabel.Size = new System.Drawing.Size(62, 16);
            this.TimeOfEditionLabel.TabIndex = 10;
            this.TimeOfEditionLabel.Text = "Modified:";
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTextBox.Location = new System.Drawing.Point(332, 129);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(720, 416);
            this.NoteTextBox.TabIndex = 12;
            // 
            // ShowCategoryLabel
            // 
            this.ShowCategoryLabel.AutoSize = true;
            this.ShowCategoryLabel.Location = new System.Drawing.Point(9, 46);
            this.ShowCategoryLabel.Name = "ShowCategoryLabel";
            this.ShowCategoryLabel.Size = new System.Drawing.Size(101, 16);
            this.ShowCategoryLabel.TabIndex = 20;
            this.ShowCategoryLabel.Text = "Show Category:";
            // 
            // CreateNoteButton
            // 
            this.CreateNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateNoteButton.FlatAppearance.BorderSize = 0;
            this.CreateNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("CreateNoteButton.Image")));
            this.CreateNoteButton.Location = new System.Drawing.Point(12, 554);
            this.CreateNoteButton.Name = "CreateNoteButton";
            this.CreateNoteButton.Size = new System.Drawing.Size(35, 35);
            this.CreateNoteButton.TabIndex = 21;
            this.CreateNoteButton.UseVisualStyleBackColor = true;
            this.CreateNoteButton.Click += new System.EventHandler(this.CreateNoteButton_Click);
            // 
            // EditNoteButton
            // 
            this.EditNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditNoteButton.FlatAppearance.BorderSize = 0;
            this.EditNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("EditNoteButton.Image")));
            this.EditNoteButton.Location = new System.Drawing.Point(63, 554);
            this.EditNoteButton.Name = "EditNoteButton";
            this.EditNoteButton.Size = new System.Drawing.Size(35, 35);
            this.EditNoteButton.TabIndex = 22;
            this.EditNoteButton.UseVisualStyleBackColor = true;
            this.EditNoteButton.Click += new System.EventHandler(this.EditNoteButton_Click);
            // 
            // DeleteNoteButton
            // 
            this.DeleteNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteNoteButton.FlatAppearance.BorderSize = 0;
            this.DeleteNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteNoteButton.Image")));
            this.DeleteNoteButton.Location = new System.Drawing.Point(116, 554);
            this.DeleteNoteButton.Name = "DeleteNoteButton";
            this.DeleteNoteButton.Size = new System.Drawing.Size(35, 35);
            this.DeleteNoteButton.TabIndex = 23;
            this.DeleteNoteButton.UseVisualStyleBackColor = true;
            this.DeleteNoteButton.Click += new System.EventHandler(this.DeleteNoteButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Category:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(327, 43);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(73, 29);
            this.NameLabel.TabIndex = 25;
            this.NameLabel.Text = "Title:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(400, 77);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(93, 16);
            this.CategoryLabel.TabIndex = 26;
            this.CategoryLabel.Text = "categoryShow";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1064, 601);
            this.Controls.Add(this.ShowCategoryLabel);
            this.Controls.Add(this.HeadNoteCategoryComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DeleteNoteButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.EditNoteButton);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.CreateNoteButton);
            this.Controls.Add(this.TitleListBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.NoteTextBox);
            this.Controls.Add(this.TimeOfEditionLabel);
            this.Controls.Add(this.TimeOfCreationLabel);
            this.Controls.Add(this.ModifitionDateTimePicker);
            this.Controls.Add(this.CreationDataTimePicker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(825, 47);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem СreateNewNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditCurrentNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteCurrentNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutTheProgramToolStripMenuItem;
        private System.Windows.Forms.ComboBox HeadNoteCategoryComboBox;
        private System.Windows.Forms.ListBox TitleListBox;
        private System.Windows.Forms.DateTimePicker CreationDataTimePicker;
        private System.Windows.Forms.DateTimePicker ModifitionDateTimePicker;
        private System.Windows.Forms.Label TimeOfCreationLabel;
        private System.Windows.Forms.Label TimeOfEditionLabel;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.Label ShowCategoryLabel;
        private System.Windows.Forms.Button CreateNoteButton;
        private System.Windows.Forms.Button EditNoteButton;
        private System.Windows.Forms.Button DeleteNoteButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CategoryLabel;
    }
}