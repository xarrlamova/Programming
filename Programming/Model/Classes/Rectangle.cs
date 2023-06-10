using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private double _length;
        private double _width;
        public string Color { get; set; }

        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("The value must be greater than zero");
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
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("The value must be greater than zero");
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
        }
    }
}
