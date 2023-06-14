using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsApp.Model
{
    /// <summary>
    /// Хранит данные о цвете.
    /// </summary>
    internal class AppColors
    {
        /// <summary>
        /// Зеленый.
        /// </summary>
        public static readonly Color Green = Color.FromArgb(127, 127, 255, 127);

        /// <summary>
        /// Красный.
        /// </summary>
        public static readonly Color Red = Color.FromArgb(201, 60, 60);

        /// <summary>
        /// Белый.
        /// </summary>
        public static readonly Color White = Color.White;

        /// <summary>
        /// Светло-розовый.
        /// </summary>
        public static readonly Color LightPink = Color.LightPink;

        /// <summary>
        /// Серый.
        /// </summary>
        public static readonly Color Gray = Color.LightGray;
    }
}
