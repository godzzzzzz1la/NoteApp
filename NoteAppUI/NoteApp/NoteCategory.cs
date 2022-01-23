using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Перечисление "Категория заметки"
    /// </summary>
    public enum NoteCategory
    {
        /// <summary>
        /// Категория "Документы"
        /// </summary>
        Documents,

        /// <summary>
        /// Категория "Финансы"
        /// </summary>
        Finance,

        /// <summary>
        /// Категория "Работа"
        /// </summary>
        Work,

        /// <summary>
        /// Категория "Люди"
        /// </summary>
        People,

        /// <summary>
        /// Категория "Здоровье"
        /// </summary>
        HealthAndSports,

        /// <summary>
        /// Категория "Дом"
        /// </summary>
        Home,

        /// <summary>
        /// Категория "Прочее"
        /// </summary>
        Other,
    }
}
