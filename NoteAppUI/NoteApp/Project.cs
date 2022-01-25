using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Класс проекта
    /// </summary>
    [Serializable]
    public class Project
    {
        /// <summary>
        /// Список заметок
        /// </summary>
        public List<Note> Notes { get; set; } = new List<Note>();

        /// <summary>
        /// Метод, для сортировки от старого к новому
        /// </summary>
        public void SortedModifiedTimeNew()
        {
            Notes.Sort((x, y) => y.ModifiedTime.CompareTo(x.ModifiedTime));
        }

        /// <summary>
        /// Метод, для сортировки от нового к старому
        /// </summary>
        public void SortedModifiedTimeOld()
        {
            Notes.Sort((x, y) => x.ModifiedTime.CompareTo(y.ModifiedTime));
        }

        /// <summary>
        /// Перегруженный метод, фильтрующий список заметок по категории заметки и сортирующий список SortResult
        /// </summary>
        /// <param name="Category"></param>
        /// <returns></returns>
        public List<Note> SortedNoteForNoteCategory(NoteCategory Category)
        {
            List<Note> SortResult = (from Item in Notes where Item.NoteCategory == Category select Item).ToList();
            SortResult.Sort((x, y) => y.ModifiedTime.CompareTo(x.ModifiedTime));
            SortedResult = SortResult;
            return SortResult;
        }

        /// <summary>
        /// Результирующий список
        /// </summary>
        public List<Note> SortedResult;

        /// <summary>
        /// Текущая заметка
        /// </summary>
        private Note _currentNote;

        /// <summary>
        /// Свойство для поля "Текущая заметка"
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
            }
        }
        public int CurrentInd { get; set; } = -1;
    }
}
