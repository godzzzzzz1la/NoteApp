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
    /// Класс главной формы
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Поле, содержащее список заметок
        /// </summary>
        private Project _project = new Project();
        List<Note> list = new List<Note>();                   
        public MainForm()
        {
            InitializeComponent();
            HeadNoteCategoryComboBox.Items.Add("New");
            HeadNoteCategoryComboBox.Items.Add("Old");
            HeadNoteCategoryComboBox.Items.Add(NoteCategory.Documents);
            HeadNoteCategoryComboBox.Items.Add(NoteCategory.Finance);
            HeadNoteCategoryComboBox.Items.Add(NoteCategory.HealthAndSports);
            HeadNoteCategoryComboBox.Items.Add(NoteCategory.Home);
            HeadNoteCategoryComboBox.Items.Add(NoteCategory.People);
            HeadNoteCategoryComboBox.Items.Add(NoteCategory.Work);
            HeadNoteCategoryComboBox.Items.Add(NoteCategory.Other);
            HeadNoteCategoryComboBox.Items.Add("All");
            HeadNoteCategoryComboBox.SelectedIndex = 9;
            int CurrentNote=-1;
            TitleListBox.SelectedIndex = CurrentNote;

        }

        /// <summary>
        /// Метод для записи данных в переменную _project при помощи метода LoadFromFile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {//Записываем данные из файла в переменную "_project" при помощи метода LoadFromFile
            _project = ProjectManager.LoadFromFile(@"..\NoteApp.txt");

            //Проверяем значение переменной "_project"
            if (_project == null)
            {
                _project = new Project();
                _project.Notes = new List<Note>();
                _project.CurrentNote = new Note();
            }

            //Очищаем TitleListBox
            TitleListBox.Items.Clear();

            try
            {
                for (var NoteNumber = 0; NoteNumber < _project.Notes.Count; NoteNumber++)
                {
                    //Записываем данные из списка Notes в переменную "item"
                    var item = _project.Notes[NoteNumber];

                    //Записываем имя заметки из переменной "item" в TitleListBox
                    TitleListBox.Items.Add(item.Name);
                }

                //Записываем данные из свойства CurrentNote в переменную "CurrentLoadNote"
                var CurrentLoadNote = _project.CurrentNote;

                NameLabel.Text = CurrentLoadNote.Name;
                CategoryLabel.Text = CurrentLoadNote.NoteCategory.ToString();
                NoteTextBox.Text = CurrentLoadNote.NoteText;
                CreationDataTimePicker.Value = CurrentLoadNote.CreationTime;
                ModifitionDateTimePicker.Value = CurrentLoadNote.ModifiedTime;

            }
            catch
            {

            }
        }
        
       
        /// <summary>
        /// Метод для создания заметки
        /// </summary>
        private void EditNote()
        {
            try
            {
                var selectedIndex = TitleListBox.SelectedIndex;
                var selectedNotes = _project.Notes[selectedIndex];
                var edit = new NoteForm();
                edit.CurrentNote = selectedNotes;
                edit.ShowDialog();
                var updateNote = edit.CurrentNote;
                TitleListBox.Items.RemoveAt(selectedIndex);
                _project.Notes.RemoveAt(selectedIndex);
                _project.Notes.Insert(selectedIndex, updateNote);
                var MainName = edit.CurrentNote.Name;
                var MainCategory = edit.CurrentNote.NoteCategory;
                var MainText = edit.CurrentNote.NoteText;
                var MainModifiedDate = edit.CurrentNote.ModifiedTime;
                TitleListBox.Items.Insert(selectedIndex, MainName);

                if (edit.DialogResult == DialogResult.OK)
                {
                    NameLabel.Text = MainName;
                    NoteTextBox.Text = MainText;
                    CategoryLabel.Text = MainCategory.ToString();
                    ModifitionDateTimePicker.Value = MainModifiedDate;
                }
                ProjectManager.SaveToFile(_project, ProjectManager.FileName);
            }
            catch
            {
                DialogResult result = MessageBox.Show("Вы не выбрали заметку!", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                this.Show();
            }
        }

        /// <summary>
        /// Метод для удаления заметки
        /// </summary>
        private void DeleteNote()
        {
            try
            {
                HeadNoteCategoryComboBox.Text = "All";
                DialogResult result = MessageBox.Show("Действительно хотите удалить заметку?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if(result == DialogResult.OK)
                {
                    var selectedIndex = TitleListBox.SelectedIndex;
                    var selectedNote = _project.Notes[selectedIndex];
                    TitleListBox.Items.RemoveAt(selectedIndex);
                    _project.Notes.RemoveAt(selectedIndex);
                    
                    NameLabel.Text = " ";
                    NoteTextBox.Text = " " ;
                    CategoryLabel.Text = " ";
                    ProjectManager.SaveToFile(_project, ProjectManager.FileName);
                }            
            }
            catch
            {
                DialogResult result = MessageBox.Show("Вы не выбрали заметку!", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                this.Show();
            }
        }      
        
        /// <summary>
        /// Кнопка для удаления заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteCurrentNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HeadNoteCategoryComboBox.Text == "All")
            {
                DeleteNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "New")
            {
                DeleteNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "Old")
            {
                DeleteNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "Documents")
            {
                DeleteNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "Finance")
            {
                DeleteNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "HealthAndSports")
            {
                DeleteNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "Home")
            {
                DeleteNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "People")
            {
                DeleteNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "Work")
            {
                DeleteNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "Other")
            {
                DeleteNote();
            }            
        }

        /// <summary>
        /// Кнопка для перехода на форму "О программе"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutTheProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.Show();
        }



        /// <summary>
        /// Кнопка для редактирования заметки в левом нижнем углу формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            if (HeadNoteCategoryComboBox.Text == "All")
            {
                EditNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "New")
            {
                EditNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "Old")
            {
                EditNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "Documents")
            {
                EditNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "Finance")
            {
                EditNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "HealthAndSports")
            {
                EditNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "Home")
            {
                EditNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "People")
            {
                EditNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "Work")
            {
                EditNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "Other")
            {
                EditNote();
            }
        }

        /// <summary>
        /// Кнопка для удаления заметки в левом нижнем углу формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteNoteButton_Click(object sender, EventArgs e)
        {
            if (HeadNoteCategoryComboBox.Text == "All")
            {
                DeleteNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "New")
            {
                DeleteNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "Old")
            {
                DeleteNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "Documents")
            {
                DeleteNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "Finance")
            {
                DeleteNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "HealthAndSports")
            {
                DeleteNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "Home")
            {
                DeleteNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "People")
            {
                DeleteNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "Work")
            {
                DeleteNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "Other")
            {
                DeleteNote();
            }
            else
            {
                DialogResult result = MessageBox.Show("Выберите, пожалуйста, категорию All", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    HeadNoteCategoryComboBox.Text = "All";
                }
            }
        }

        /// <summary>
        /// Событие, для установки значение индекса заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var Form = new Note();
                if(TitleListBox.SelectedIndex >= 0)
                {
                    Note _clicklist;    
                    
                    if(HeadNoteCategoryComboBox.Text == "All")
                    {
                       
                        _clicklist = _project.Notes[TitleListBox.SelectedIndex];
                        NameLabel.Text = _clicklist.Name;
                        NoteTextBox.Text = _clicklist.NoteText;
                        CategoryLabel.Text = _clicklist.NoteCategory.ToString();
                        CreationDataTimePicker.Value = _clicklist.CreationTime;
                        ModifitionDateTimePicker.Value = _clicklist.ModifiedTime;
                        _project.CurrentNote = _clicklist;
                    }
                    else if (HeadNoteCategoryComboBox.Text == "New")
                    {

                        _clicklist = _project.Notes[TitleListBox.SelectedIndex];
                        NameLabel.Text = _clicklist.Name;
                        NoteTextBox.Text = _clicklist.NoteText;
                        CategoryLabel.Text = _clicklist.NoteCategory.ToString();
                        CreationDataTimePicker.Value = _clicklist.CreationTime;
                        ModifitionDateTimePicker.Value = _clicklist.ModifiedTime;
                        _project.CurrentNote = _clicklist;
                    }
                    else if (HeadNoteCategoryComboBox.Text == "New")
                    {

                        _clicklist = _project.Notes[TitleListBox.SelectedIndex];
                        NameLabel.Text = _clicklist.Name;
                        NoteTextBox.Text = _clicklist.NoteText;
                        CategoryLabel.Text = _clicklist.NoteCategory.ToString();
                        CreationDataTimePicker.Value = _clicklist.CreationTime;
                        ModifitionDateTimePicker.Value = _clicklist.ModifiedTime;
                        _project.CurrentNote = _clicklist;
                    }
                    else if (HeadNoteCategoryComboBox.Text == "Old")
                    {
                        _clicklist = _project.Notes[TitleListBox.SelectedIndex];
                        NameLabel.Text = _clicklist.Name;
                        NoteTextBox.Text = _clicklist.NoteText;
                        CategoryLabel.Text = _clicklist.NoteCategory.ToString();
                        CreationDataTimePicker.Value = _clicklist.CreationTime;
                        ModifitionDateTimePicker.Value = _clicklist.ModifiedTime;
                        _project.CurrentNote = _clicklist;
                    }
                    else
                    {
                        //Присваиваем переменной данные из списка по индексу
                        _clicklist = _project.SortedResult[TitleListBox.SelectedIndex];


                        //Присваиваем полям значения из переменной списка
                        NameLabel.Text = _clicklist.Name;
                        NoteTextBox.Text = _clicklist.NoteText;
                        CategoryLabel.Text = _clicklist.NoteCategory.ToString();
                        CreationDataTimePicker.Value = _clicklist.CreationTime;
                        ModifitionDateTimePicker.Value = _clicklist.ModifiedTime;

                        _project.CurrentNote = _clicklist;
                    }
                    ProjectManager.SaveToFile(_project, ProjectManager.FileName);
                }               
               
            }
            catch
            {
                this.Show();
            }
        }

        /// <summary>
        /// Метод для передачи отсортированного массива в ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeadNoteCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(HeadNoteCategoryComboBox.Text == "New")
            {
                TitleListBox.Items.Clear();
                _project.SortedModifiedTimeNew();
                for(var ForTimeNew = 0; ForTimeNew< _project.Notes.Count; ForTimeNew++)
                {
                    var Data = _project.Notes[ForTimeNew];
                    TitleListBox.Items.Add(Data.Name);
                }
            }
            else if(HeadNoteCategoryComboBox.Text == "Old")
            {
                TitleListBox.Items.Clear();
                _project.SortedModifiedTimeOld();
                for (var ForTimeOld = 0; ForTimeOld < _project.Notes.Count; ForTimeOld++)
                {
                    var Data = _project.Notes[ForTimeOld];
                    TitleListBox.Items.Add(Data.Name);
                }
            }
            else if(HeadNoteCategoryComboBox.Text == "Documents")
            {
                SortedCategory();
            }
            else if (HeadNoteCategoryComboBox.Text == "Finance")
            {
                SortedCategory();
            }
            else if (HeadNoteCategoryComboBox.Text == "Work")
            {
                SortedCategory();
            }
            else if (HeadNoteCategoryComboBox.Text == "People")
            {
                SortedCategory();
            }
            else if (HeadNoteCategoryComboBox.Text == "HealthAndSports")
            {
                SortedCategory();
            }
            else if (HeadNoteCategoryComboBox.Text == "Home")
            {
                SortedCategory();
            }
            else if (HeadNoteCategoryComboBox.Text == "Other")
            {
                SortedCategory();
            }
            else if(HeadNoteCategoryComboBox.Text == "All")
            {
                TitleListBox.Items.Clear();
                for(var i=0; i< _project.Notes.Count; i++)
                {
                    var Data = _project.Notes[i];
                    TitleListBox.Items.Add(Data.Name);
                }
               
            }

        }

        /// <summary>
        /// Метод для сортировки категорий заметки
        /// </summary>
        public void SortedCategory()
        {
            var category = (NoteCategory)HeadNoteCategoryComboBox.SelectedItem;
            _project.SortedNoteForNoteCategory(category);
            TitleListBox.Items.Clear();
            for(var i = 0; i < _project.SortedResult.Count; i++)
            {
                var DataSortedResult = _project.SortedResult[i];
                TitleListBox.Items.Add(DataSortedResult.Name);
            }

        }

        /// <summary>
        /// Кнопка для создания заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateNoteButton_Click(object sender, EventArgs e)
        {
            CreateFunction();
        }

        /// <summary>
        /// Кнопка для редактирования заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditCurrentNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HeadNoteCategoryComboBox.Text == "All")
            {
                EditNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "New")
            {
                EditNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "Old")
            {
                EditNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "Documents")
            {
                EditNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "Finance")
            {
                EditNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "HealthAndSports")
            {
                EditNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "Home")
            {
                EditNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "People")
            {
                EditNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "Work")
            {
                EditNote();
            }
            else if (HeadNoteCategoryComboBox.Text == "Other")
            {
                EditNote();
            }           
        }

        /// <summary>
        /// Метод для создания заметки
        /// </summary>
        private void CreateFunction()
        {
            HeadNoteCategoryComboBox.Text = "All";
            var form = new NoteForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                var MainName = form.CurrentNote.Name;
                var MainCategory = form.CurrentNote.NoteCategory;
                var MainText = form.CurrentNote.NoteCategory;
                var MainCreatedTime = form.CurrentNote.CreationTime;
                var MainModifiedTime = form.CurrentNote.ModifiedTime;
                TitleListBox.Items.Add(MainName);
                _project.Notes.Add(form.CurrentNote);
                ProjectManager.SaveToFile(_project, ProjectManager.FileName);
            }
        }

        /// <summary>
        /// Кнопка для создания заметки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void СreateNewNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateFunction();
        }
    }
}
