using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsApp.Model.Classes
{
    /// <summary>
    /// Хранит в себе данные о ID последнего добавленного студента и о списке студентов.
    /// </summary>
    public class Dto
    {
        /// <summary>
        /// Возвращает и задает ID последнего добавленного студента.
        /// </summary>
        public int ID { get; set; }
        
        /// <summary>
        /// Список студентов.
        /// </summary>
        public List<Student> StudentsCollection { get; set; }

    }
}
