using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Описывает кольцо, его внутренний радиус, внешний радиус, Id, координаты (х,у) его центра.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Внутрений радиус.
        /// </summary>
        private double _innerRadius;
        /// <summary>
        /// Внешний радиус.
        /// </summary>
        private double _outerRadius;
        /// <summary>
        /// Возвращает и задает координаты центра кольца.
        /// </summary>
        public Point2D Centre { get; set; }
        /// <summary>
        /// Возвращает и задает внутренний радиус кольца. 
        /// Внутренний радиус не может быть больше внешнего. Должен быть положительным.
        /// </summary>
        public double InnerRadius
        {
            get => _innerRadius;
            private set
            {
                Validator.AssertValueInRange(value, 0, OuterRadius, nameof(InnerRadius));
                _innerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задает внешний радиус кольца. 
        /// Внешний радиус не может быть меньше внутреннего. Должен быть положительным.
        /// </summary>
        public double OuterRadius
        {
            get => _outerRadius;
            private set
            {
                Validator.AssertValueInRange(value, InnerRadius, double.MaxValue, nameof(OuterRadius));
                _outerRadius = value;
            }
        }
        /// <summary>
        /// Возвращает площадь кольца.
        /// </summary>
        /// <param name="ring">Кольцо, для которого ищем площадь.</param>
        /// <returns>Возвращает значение площади кольца.
        /// (Разность площади круга, образуемого внешним радиусом, и площади круга, 
        /// образуемого внутренним радиусом.)</returns>
        private static double Area(Ring ring)
        {
            double area = Math.PI * Math.Pow(ring.OuterRadius, 2) - Math.PI * Math.Pow(ring.InnerRadius, 2);
            return area;
        }
        /// <summary>
        /// Возвращает и задает количество созданных колец.
        /// </summary>
        public static int AllRingsCount { get; set; }
        /// <summary>
        /// Возвращает Id кольца.
        /// </summary>
        public int Id { get; }
        /// <summary>
        /// Создает объект класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="outerRadius">Внешний радиус кольца. 
        /// Внешний радиус не может быть меньше внутреннего. Должен быть положительным.</param>
        /// <param name="innerRadius">Внутренний радиус кольца. 
        /// Внутренний радиус не может быть больше внешнего. Должен быть положительным.</param>
        /// <param name="x">Координата точки х - середины кольца. Должна быть положительной.</param>
        /// <param name="y">Координата точки у - середины кольца. Должна быть положительной.</param>
        public Ring(double outerRadius, double innerRadius, int x, int y)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Centre = new Point2D(x, y);
            Id = AllRingsCount;
            AllRingsCount++;
        }

        /// <summary>
        /// Создает объект класса <see cref="Ring"/>.
        /// </summary>
        public Ring()
        {
        }
    }
}
