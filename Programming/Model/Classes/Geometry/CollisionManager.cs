﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Хранит методы для проверки геометрических фигур на их пересечения/столкновения.
    /// </summary>
    public class CollisionManager
    {
        /// <summary>
        /// Проверяет, пересекаются/сталкиваются ли треугольники.
        /// </summary>
        /// <param name="rectangle1"> Первый прямоугольник. </param>
        /// <param name="rectangle2"> Второй прямоугольник. </param>
        /// <returns> Возвращает truе, если прямоугольники пересекаются/сталкиваются. Возвращает false, если нет.</returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            return Math.Abs(rectangle1.Centre.X - rectangle2.Centre.X) < rectangle1.Length / 2 + rectangle2.Length / 2
                && Math.Abs(rectangle1.Centre.Y - rectangle2.Centre.Y) < rectangle1.Width / 2 + rectangle2.Width / 2;
        }

        /// <summary>
        /// Проверяет, пересекаются/сталкиваются ли кольца.
        /// </summary>
        /// <param name="ring1"> Первое кольцо.</param>
        /// <param name="ring2"> Второе кольцо.</param>
        /// <returns> Возвращает truе, если кольца пересекаются/сталкиваются. Возвращает false, если нет.</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double x_s = Math.Abs(ring1.Centre.X - ring2.Centre.X);
            double y_s = Math.Abs(ring1.Centre.Y - ring2.Centre.Y);
            return Math.Sqrt(Math.Pow(x_s, 2) + Math.Pow(y_s, 2)) < ring1.OuterRadius + ring2.OuterRadius;
        }
    }
}
