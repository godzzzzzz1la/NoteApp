using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// ///Класс "Заметка", содержащий поля:«Название», «Категория заметки», 
    ///«Текст заметки», «Время создания», «Время последнего изменения».
    /// </summary>
    [Serializable]
    public class Note : ICloneable
    {
        ///<summary>
        ///"Название заметки"
        ///</summary>
        private string _name;

        /// <summary>
        /// Свойство для поля "Название заметки"
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length == 0)
                {
                    _name = "Без названия";
                    return;
                }
                if (value.Length > 50)
                {
                    throw new ArgumentException("Длина названия больше 50 символов!");
                }
                else
                {
                    _name = value;
                }
            }
        }

        /// <summary>
        /// Свойство для поля "Категория заметки"
        /// </summary>
        public NoteCategory NoteCategory { get; set; }

        ///<summary>
        ///"Текст заметки"
        ///</summary>
        private string _noteText;

        /// <summary>
        /// Свойство для поля "Текст заметки"
        /// </summary>
        public string NoteText
        {
            get
            {
                return _noteText;
            }
            set
            {
               _noteText = value;
            }
        }

        /// <summary>
        /// "Дата создания заметки"
        /// </summary>
        private static DateTime _creationTime;

        /// <summary>
        /// Свойство для поля "Дата создания заметки"
        /// </summary>
        public DateTime CreationTime
        {
            get
            {
                return _creationTime;
            }
            set
            {
                _creationTime = value;
                if (_creationTime > DateTime.Now)
                {
                    throw new ArgumentException("Неверная дата создания заметки");
                }
            }
        }

        /// <summary>
        /// "Дата изменения заметки"
        /// </summary>
        private DateTime _modifiedTime;

        /// <summary>
        /// Свойство для поля "Дата изменения заметки"
        /// </summary>
        public DateTime ModifiedTime
        {
            get
            {
                return _modifiedTime;
            }
            set
            {
                _modifiedTime = value;
               
            }
        }

        /// <summary>
        /// Метод, который возвращает копию объекта
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        /// <summary>
        /// Конструктор, для установки значений 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="text"></param>
        /// <param name="category"></param>
        public Note(string name, string text, NoteCategory category)
        {
            this.Name = name;
            this.NoteText = text;
            this.NoteCategory = category;
            ModifiedTime = DateTime.Now;
            CreationTime = DateTime.Now;

        }

        public Note()
        {
        }

        /// <summary>
        /// Сравнивает значения двух заметок
        /// </summary>
        /// <param name="obj">Заметка, с которой идет сравнение</param>
        /// <returns>true, если все поля одной заметки совпадают с другой, иначе - false</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Note other))
            {
                return false;
            }

            return Name == other.Name && NoteText == other.NoteText && NoteCategory == other.NoteCategory &&
                CreationTime == other.CreationTime && ModifiedTime == other.ModifiedTime;
        }
    }
}
