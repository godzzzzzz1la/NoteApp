using System;
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
        private Note _currentNote = new Note();

        /// <summary>
        /// Свойство для поля текущей заметки
        /// </summary>
        public Note CurrentNote
        {
            get
            {
                return _currentNote;
            }
            set
            {
                _currentNote = value;
                if(_currentNote != null)
                {
                    AddNameTextBox.Text = _currentNote.Name;
                    AddCategoryComboBox.Text = _currentNote.NoteCategory.ToString();
                    AddTextNoteTextBox.Text = _currentNote.NoteText;
                    CreateDateTimePicker.Value = _currentNote.CreationTime;
                    ModifyDateTimePicker.Value = _currentNote.ModifiedTime;
                }
            }
        }        
        /// <summary>
        /// Конструктор формы
        /// </summary>
        public NoteForm()
        {
            InitializeComponent();
            AddCategoryComboBox.Items.Add(NoteCategory.Documents);
            AddCategoryComboBox.Items.Add(NoteCategory.Finance);
            AddCategoryComboBox.Items.Add(NoteCategory.Work);
            AddCategoryComboBox.Items.Add(NoteCategory.People);
            AddCategoryComboBox.Items.Add(NoteCategory.HealthAndSports);
            AddCategoryComboBox.Items.Add(NoteCategory.Home);
            AddCategoryComboBox.Items.Add(NoteCategory.Other);
        }
                   
        

        /// <summary>
        /// Кнопка "Окей"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (AddNameTextBox.TextLength <= 50)
            {
                this.DialogResult = DialogResult.OK;

                Note note = new Note();
                Project project = new Project();

                _currentNote.Name = AddNameTextBox.Text;
                _currentNote.NoteText = AddTextNoteTextBox.Text;
                _currentNote.NoteCategory = (NoteCategory)AddCategoryComboBox.SelectedItem;
                _currentNote.CreationTime = CreateDateTimePicker.Value;
                _currentNote.ModifiedTime = ModifyDateTimePicker.Value;
                this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("Длина имени заметки должна быть меньше либо равна 50 символам!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Show();
            }
        }

        /// <summary>
        ///  Кнопка "отмена"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Действительно хотите отменить редактирование?", "Отмена", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK) { this.Close(); }
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
      
    }
}
