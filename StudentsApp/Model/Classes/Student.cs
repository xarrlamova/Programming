using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace StudentsApp.Model.Classes
{
    /// <summary>
    /// Хранит данные о студенте.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Возвращает и задает полное имя студента.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Возвращает и задает уникальный ID студента.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Возвращает и задает группу студента.
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        /// Возвращает и задает форму обучения студента.
        /// </summary>
        public string EducationForm { get; set; }

        /// <summary>
        /// Возвращает и задает факультет студента.
        /// </summary>
        public string Faculty { get; set; }

        // RSDN
        /// <summary>
        /// Создает экземпляр класса <see cref="Student"/>.
        /// </summary>
        /// <param name="fullName">Полное имя студента. Строка не должна превышать 200 символов.</param>
        /// <param name="group">Группа студента. Строка не может превышать 10 символов.</param>
        /// <param name="faculty">Факультет студента.</param>
        /// <param name="educationForm">Форма обучения студента.</param>
        public Student(string fullName, string group, string faculty, string educationForm, int id)
        {
            FullName = fullName;
            Group = group;
            Faculty = faculty;
            EducationForm = educationForm;
            Id = id;
        }
        
        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Student"/>.
        /// </summary>
        public Student()
        {

        }

        /// <summary>
        /// Метод для вывода строки.
        /// </summary>
        /// <returns>Возвращает строку в нужном формате.</returns>
        public override string ToString()
        {
            return $"{FullName} - {Group} / {Faculty}";
        }
    }
}
