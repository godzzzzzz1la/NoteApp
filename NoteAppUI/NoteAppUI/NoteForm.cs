﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    /// <summary>
    /// Класс формы, для создания или редактирования заметки
    /// </summary>
    public partial class NoteForm : Form
    {

        /// <summary>
        /// Поле текущей заметки
        /// </summary>
        public Note CurrentNote { get; set; }

        public NoteForm()
        {
            InitializeComponent();
            var categories = Enum.GetValues(typeof(NoteCategory)).Cast<object>().ToArray();
            AddCategoryComboBox.Items.AddRange(categories);
            AddCategoryComboBox.SelectedIndex = 0;
        }
                   
        

        /// <summary>
        /// Кнопка "Окей"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (AddCategoryComboBox.SelectedIndex != -1)
                {
                    var currentCategory = (NoteCategory)AddCategoryComboBox.SelectedIndex;
                    CurrentNote = new Note(AddNameTextBox.Text, AddTextNoteTextBox.Text, currentCategory);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Note category not selected!");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Метод, для заполнения элементов информацией о текущей заметке
        /// </summary>
        private void ShowNoteInfo()
        {
            AddNameTextBox.Text = CurrentNote.Name;
            AddTextNoteTextBox.Text = CurrentNote.Text;
            AddCategoryComboBox.Text = CurrentNote.Category.ToString();
            CreateDateTimePicker.Value = CurrentNote.CreatedTime;
            ModifyDateTimePicker.Value = CurrentNote.ModifiedTime;
        }
        /// <summary>
        ///  Кнопка "отмена"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
      
        /// <summary>
        /// Метод, для изменения цвета AddNametextBox, если длина текста больше 50
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string CurrentName = AddTextNoteTextBox.Text;
                if (CurrentName.Length >= 50)
                {
                    AddNameTextBox.BackColor = Color.LightSalmon;
                }
                else
                {
                    AddNameTextBox.BackColor= Color.White;
                }
            }
            catch
            {
                this.Show();
            }
        }

        private void NoteForm_Load(object sender, EventArgs e)
        {
            if (CurrentNote != null)
            {
                ShowNoteInfo();
            }
        }
    }
}
