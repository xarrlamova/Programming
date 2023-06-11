using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    internal class RectangleFactory
    {
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
