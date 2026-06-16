using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsApp.Model.Enums
{
    /// <summary>
    /// Перечисление, содержащие формы обучения.
    /// </summary>
    public enum EducationForm
    {
        /// <summary>
        /// Очная.
        /// </summary>
        Fulltime,

        /// <summary>
        /// Заочная.
        /// </summary>
        Correspondence,

        /// <summary>
        /// Вечерняя.
        /// </summary>
        Evening,

        /// <summary>
        /// Дистанционная.
        /// </summary>
        Distance
    }
}
