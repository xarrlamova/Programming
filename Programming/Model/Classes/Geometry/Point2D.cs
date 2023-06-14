using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Описывает точку в двумерном пространстве Point2D, хранящей координаты X и Y
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Координата точки х.
        /// </summary>
        private int _x;
        /// <summary>
        /// Координата точки у.
        /// </summary>
        private int _y;

        /// <summary>
        /// Возвращает и задает координату точки х. Должна быть положительной.
        /// </summary>
        public int X
        {
            get => _x;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(X));
                _x = value;
            }
        }

        /// <summary>
        /// Возвращает и задает координату точки у. Должна быть положительной.
        /// </summary>
        public int Y
        {
            get => _y;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Y));
                _y = value;
            }
        }

        /// <summary>
        /// Создает объект класса <see cref="Point2D"/>.
        /// </summary>
        public Point2D()
        {
        }

        /// <summary>
        /// Создает объект класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x">Координата точки х. Должна быть положительной.</param>
        /// <param name="y">Координата точки у. Должна быть положительной.</param>
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
