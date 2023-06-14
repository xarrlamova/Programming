using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Хранит метод для создания прямоугольников.  
    /// </summary>
    public class RectangleFactory
    {
        /// <summary>
        /// Создает прямоугольник. 
        /// </summary>
        /// <param name="RectPanel">Размер канвы для ограничения координат центра прямоугольника.</param>
        /// <returns>Возвращает прямоугольник.</returns>
        public Rectangle Randomize(Panel RectPanel)
        {
            Random _rand = new Random();
            return new Rectangle(Math.Round(_rand.NextDouble() * 100, 1),
            Math.Round(_rand.NextDouble() * 100, 1),
            "Green", _rand.Next(1, RectPanel.Size.Width),
                    _rand.Next(1, RectPanel.Size.Height));
        }
    }
}
