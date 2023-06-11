using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    public class Rectangle
    {
        private double _length;
        private double _width;
        public int Id { get; }
        public Point2D Centre { get; set; }
        public string Color { get; set; }

        private static int _allRectanglesCount;
        public static int AllRectanglesCount
        {
            get => _allRectanglesCount;
            private set
            {
                _allRectanglesCount = value;
            }
        }


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


        public Rectangle()
        {

        }


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
