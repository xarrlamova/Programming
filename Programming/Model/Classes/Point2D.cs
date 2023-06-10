using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Point2D
    {
        private int _x;
        private int _y;

        public int X
        {
            get => _x;
            private set
            {
                Validator.AssertOnPositiveValue(value, nameof(X));
                _x = value;
            }
        }
        public int Y
        {
            get => _y;
            private set
            {
                Validator.AssertOnPositiveValue(value, nameof(Y));
                _y = value;
            }
        }
        public Point2D()
        {
        }
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
