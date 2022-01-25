
namespace NoteAppUI
{
    partial class NoteForm
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
            this.AddNameTextBox = new System.Windows.Forms.TextBox();
            this.CreateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.AddTextNoteTextBox = new System.Windows.Forms.TextBox();
            this.AddNameLabel = new System.Windows.Forms.Label();
            this.CreationTimeLabel = new System.Windows.Forms.Label();
            this.NoteCategoryLabel = new System.Windows.Forms.Label();
            this.ModifyTimeLable = new System.Windows.Forms.Label();
            this.ModifyDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNameTextBox
            // 
            this.AddNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNameTextBox.Location = new System.Drawing.Point(90, 28);
            this.AddNameTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddNameTextBox.Multiline = true;
            this.AddNameTextBox.Name = "AddNameTextBox";
            this.AddNameTextBox.Size = new System.Drawing.Size(961, 24);
            this.AddNameTextBox.TabIndex = 0;
            this.AddNameTextBox.TextChanged += new System.EventHandler(this.AddNameTextBox_TextChanged);
            // 
            // CreateDateTimePicker
            // 
            this.CreateDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CreateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CreateDateTimePicker.Location = new System.Drawing.Point(90, 98);
            this.CreateDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.CreateDateTimePicker.Name = "CreateDateTimePicker";
            this.CreateDateTimePicker.Size = new System.Drawing.Size(108, 22);
            this.CreateDateTimePicker.TabIndex = 2;
            // 
            // AddCategoryComboBox
            // 
            this.AddCategoryComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.AddCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddCategoryComboBox.DropDownWidth = 181;
            this.AddCategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCategoryComboBox.FormattingEnabled = true;
            this.AddCategoryComboBox.Location = new System.Drawing.Point(90, 61);
            this.AddCategoryComboBox.Name = "AddCategoryComboBox";
            this.AddCategoryComboBox.Size = new System.Drawing.Size(146, 24);
            this.AddCategoryComboBox.TabIndex = 1;
            // 
            // AddTextNoteTextBox
            // 
            this.AddTextNoteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTextNoteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTextNoteTextBox.Location = new System.Drawing.Point(13, 124);
            this.AddTextNoteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AddTextNoteTextBox.Multiline = true;
            this.AddTextNoteTextBox.Name = "AddTextNoteTextBox";
            this.AddTextNoteTextBox.Size = new System.Drawing.Size(1038, 423);
            this.AddTextNoteTextBox.TabIndex = 5;
            // 
            // AddNameLabel
            // 
            this.AddNameLabel.AutoSize = true;
            this.AddNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNameLabel.Location = new System.Drawing.Point(13, 28);
            this.AddNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddNameLabel.Name = "AddNameLabel";
            this.AddNameLabel.Size = new System.Drawing.Size(36, 16);
            this.AddNameLabel.TabIndex = 5;
            this.AddNameLabel.Text = "Title:";
            // 
            // CreationTimeLabel
            // 
            this.CreationTimeLabel.AutoSize = true;
            this.CreationTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreationTimeLabel.Location = new System.Drawing.Point(13, 103);
            this.CreationTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CreationTimeLabel.Name = "CreationTimeLabel";
            this.CreationTimeLabel.Size = new System.Drawing.Size(58, 16);
            this.CreationTimeLabel.TabIndex = 6;
            this.CreationTimeLabel.Text = "Created:";
            // 
            // NoteCategoryLabel
            // 
            this.NoteCategoryLabel.AutoSize = true;
            this.NoteCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteCategoryLabel.Location = new System.Drawing.Point(13, 64);
            this.NoteCategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NoteCategoryLabel.Name = "NoteCategoryLabel";
            this.NoteCategoryLabel.Size = new System.Drawing.Size(65, 16);
            this.NoteCategoryLabel.TabIndex = 10;
            this.NoteCategoryLabel.Text = "Category:";
            // 
            // ModifyTimeLable
            // 
            this.ModifyTimeLable.AutoSize = true;
            this.ModifyTimeLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModifyTimeLable.Location = new System.Drawing.Point(223, 103);
            this.ModifyTimeLable.Name = "ModifyTimeLable";
            this.ModifyTimeLable.Size = new System.Drawing.Size(62, 16);
            this.ModifyTimeLable.TabIndex = 11;
            this.ModifyTimeLable.Text = "Modified:";
            // 
            // ModifyDateTimePicker
            // 
            this.ModifyDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ModifyDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModifyDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ModifyDateTimePicker.Location = new System.Drawing.Point(308, 98);
            this.ModifyDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.ModifyDateTimePicker.Name = "ModifyDateTimePicker";
            this.ModifyDateTimePicker.Size = new System.Drawing.Size(110, 22);
            this.ModifyDateTimePicker.TabIndex = 12;
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkButton.Location = new System.Drawing.Point(911, 555);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(67, 34);
            this.OkButton.TabIndex = 13;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Location = new System.Drawing.Point(984, 555);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(67, 34);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1064, 601);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ModifyDateTimePicker);
            this.Controls.Add(this.ModifyTimeLable);
            this.Controls.Add(this.NoteCategoryLabel);
            this.Controls.Add(this.CreationTimeLabel);
            this.Controls.Add(this.AddNameLabel);
            this.Controls.Add(this.AddTextNoteTextBox);
            this.Controls.Add(this.AddCategoryComboBox);
            this.Controls.Add(this.CreateDateTimePicker);
            this.Controls.Add(this.AddNameTextBox);
            this.MinimumSize = new System.Drawing.Size(450, 262);
            this.Name = "NoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Note";
            this.Load += new System.EventHandler(this.NoteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddNameTextBox;
        private System.Windows.Forms.DateTimePicker CreateDateTimePicker;
        private System.Windows.Forms.ComboBox AddCategoryComboBox;
        private System.Windows.Forms.TextBox AddTextNoteTextBox;
        private System.Windows.Forms.Label AddNameLabel;
        private System.Windows.Forms.Label CreationTimeLabel;
        private System.Windows.Forms.Label NoteCategoryLabel;
        private System.Windows.Forms.Label ModifyTimeLable;
        private System.Windows.Forms.DateTimePicker ModifyDateTimePicker;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
    }
}