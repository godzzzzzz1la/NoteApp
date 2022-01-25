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
        private Project project { get; set; }
        /// <summary>
        /// Список отсортированных заметок
        /// </summary>
        private List<Note> NotesSort { get; set; }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            project = ProjectManager.LoadFromFile(ProjectManager.FilePath);
            NotesSort = new List<Note>();
            UpdateListBox();
            var categories = Enum.GetValues(typeof(NoteCategory)).Cast<object>().ToArray();
            HeadNoteCategoryComboBox.Items.Add("All");
            HeadNoteCategoryComboBox.Items.AddRange(categories);
            HeadNoteCategoryComboBox.SelectedIndex = 0;
            if (project.CurrentNote == -1)
                Clear();
            else
                TitleListBox.SelectedIndex = project.CurrentNote;
        }

        /// <summary>
        /// Метод, который обновляет список заметок в листбоксе
        /// </summary>
        void UpdateListBox()
        {
            
            TitleListBox.Items.Clear();
            if ((HeadNoteCategoryComboBox.Text == "All"))
            {
                project.Notes = project.SortList();
                for (int i = 0; i < project.Notes.Count; i++)
                {
                    TitleListBox.Items.Add(project.Notes[i].Name);
                }
            }
            else
            {
                var category = (NoteCategory)HeadNoteCategoryComboBox.SelectedIndex - 1;
                NotesSort = project.SortList(category);
                for (int i = 0; i < NotesSort.Count; i++)
                {
                    TitleListBox.Items.Add(NotesSort[i].Name);
                }
            }
        }

        /// <summary>
        /// Метод очищения формы
        /// </summary>
        void Clear()
        {
            NameLabel.Text = "";
            CategoryLabel.Text = "";
            CreationDataTimePicker.Value = DateTime.Now;
            ModifitionDateTimePicker.Value = DateTime.Now;
            NoteTextBox.Text = "";
        }

        /// <summary>
        ///  Метод, для отображения информации заметки
        /// </summary>
        private void ShowNoteInfo()
        {
            var showProject = HeadNoteCategoryComboBox.Text == "All" ? project.Notes : NotesSort;
            var note = showProject[TitleListBox.SelectedIndex];
            NameLabel.Text = note.Name;
            NoteTextBox.Text = note.Text;
            CreationDataTimePicker.Value = note.CreatedTime;
            ModifitionDateTimePicker.Value = note.ModifiedTime;
            CategoryLabel.Text = note.Category.ToString();

        }

        /// <summary>
        /// Событие, для установки значения индекса заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (TitleListBox.SelectedIndex == -1)
                {
                    return;
                }
                ShowNoteInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Метод для создания заметки
        /// </summary>
        private void EditNote()
        {
            if (TitleListBox.SelectedIndex != -1)
            {
                var showProject = HeadNoteCategoryComboBox.Text == "All" ? project.Notes : NotesSort;

                NoteForm form = new NoteForm();
                form.CurrentNote = showProject[TitleListBox.SelectedIndex];

                if (form.ShowDialog() == DialogResult.OK)
                {
                    showProject[TitleListBox.SelectedIndex].Name = form.CurrentNote.Name;
                    showProject[TitleListBox.SelectedIndex].Text = form.CurrentNote.Text;
                    showProject[TitleListBox.SelectedIndex].Category = form.CurrentNote.Category;
                    showProject[TitleListBox.SelectedIndex].ModifiedTime = form.CurrentNote.ModifiedTime;
                    UpdateListBox();
                    if (TitleListBox.Items.Count > 0)
                    {
                        TitleListBox.SelectedIndex = 0;
                    }
                    else
                    {
                        Clear();
                        return;
                    }

                    ShowNoteInfo();
                    ProjectManager.SaveToFile(project, ProjectManager.FilePath);
                }
                else
                {
                    MessageBox.Show("Note not selected!");
                }
            }
        }

        /// <summary>
        /// Метод для удаления заметки
        /// </summary>
        private void DeleteNote()
        {
            if (TitleListBox.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Do you want to remove this note: " +
                                                      project.Notes[TitleListBox.SelectedIndex].Name + "",
                    "Remove Note", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    project.Notes.RemoveAt(TitleListBox.SelectedIndex);
                    UpdateListBox();
                    if (TitleListBox.Items.Count > 0)
                    {
                        TitleListBox.SelectedIndex = 0;
                    }
                    else if (TitleListBox.Items.Count == 0)
                    {
                        Clear();
                    }
                }
                if (result == DialogResult.Cancel)
                {
                    DialogResult = DialogResult.Cancel;
                }
                ProjectManager.SaveToFile(project, ProjectManager.FilePath);
            }
            else
            {
                MessageBox.Show("Note not selected!");
            }
        }      
        
        /// <summary>
        /// Кнопка для удаления заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteCurrentNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
                DeleteNote();               
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
            EditNote();
        }

        /// <summary>
        /// Кнопка для удаления заметки в левом нижнем углу формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteNoteButton_Click(object sender, EventArgs e)
        {
                DeleteNote();
           
        }

        /// <summary>
        /// Событие, для установки значение индекса заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TitleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (TitleListBox.SelectedIndex == -1)
                {
                    return;
                }
                ShowNoteInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Метод для передачи отсортированного массива в ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeadNoteCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBox();
            if (TitleListBox.Items.Count > 0)
            {
                TitleListBox.SelectedIndex = 0;
            }
            if (TitleListBox.Items.Count == 0)
            {
                Clear();
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
            EditNote();
        }

        /// <summary>
        /// Метод для создания заметки
        /// </summary>
        private void CreateFunction()
        {
            NoteForm form = new NoteForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                project.Notes.Add(form.CurrentNote);
                UpdateListBox();
                if (TitleListBox.Items.Count > 0)
                    TitleListBox.SelectedIndex = 0;
                ProjectManager.SaveToFile(project, ProjectManager.FilePath);
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

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            project.CurrentNote = TitleListBox.SelectedIndex;
            ProjectManager.SaveToFile(project, ProjectManager.FilePath);
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
