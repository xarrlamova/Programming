using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Возвращает рандомные значения параметров прямоугольника. Длину, ширину, цвет,
    /// координаты (х,у) середины прямоугольника.
    /// </summary>
    public class RectangleFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="RectPanel"></param>
        /// <returns></returns>
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
