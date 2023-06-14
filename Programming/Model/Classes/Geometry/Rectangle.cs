using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Описывает прямоугольник, его длину, ширину, цвет, Id, координаты (х,у) его центра.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Длина.
        /// </summary>
        private double _length;
        /// <summary>
        /// Ширина.
        /// </summary>
        private double _width;
        /// <summary>
        /// Возвращает Id прямоугольника.
        /// </summary>
        public int Id { get; }
        /// <summary>
        /// Возвращает и задает координаты центра прямоугольника.
        /// </summary>
        public Point2D Centre { get; set; }
        /// <summary>
        /// Цвет.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Количество созданных прямоугольников.
        /// </summary>
        private static int _allRectanglesCount;
        /// <summary>
        /// Возвращает количество созданных прямоугольников.
        /// </summary>
        public static int AllRectanglesCount
        {
            get => _allRectanglesCount;
            private set
            {
                _allRectanglesCount = value;
            }
        }

        /// <summary>
        /// Возвращает и задает длину прямоугольника. Должна быть положительной.
        /// </summary>
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Length));
                _length = value;
            }
        }

        /// <summary>
        /// Возвращает и задает ширину прямоугольника. Должна быть положительной.
        /// </summary>
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

        /// <summary>
        /// Создает объект класса <see cref="Rectangle"/>
        /// </summary>
        public Rectangle()
        {

        }

        /// <summary>
        /// Создает объект класса <see cref="Rectangle"/>
        /// </summary>
        /// <param name="length">Длина прямоугольника. Должна быть положительной.</param>
        /// <param name="width">Ширина прямоугольника. Должна быть положительной.</param>
        /// <param name="color">Цвет прямоугольника.</param>
        /// <param name="x">Координата точки х - середины прямоугольника. Должна быть положительной.</param>
        /// <param name="y">Координата точки у - середины прямоугольника. Должна быть положительной.</param>
        public Rectangle(double length, double width, string color, int x, int y)
        {
            Length = length;
            Width = width;
            Color = color;
            Centre = new Point2D(x, y);
            Id = AllRectanglesCount;
            AllRectanglesCount++;
        }
    }
}
