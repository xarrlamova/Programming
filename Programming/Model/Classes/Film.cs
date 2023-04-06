using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    internal class Film
    {
        public string Title;
        public int DurationInMinutes;
        private int _yearOfRelease;
        public string Genre;
        private float _rating;

        public int YearOfRelease
        {
            get
            {
                return _yearOfRelease;
            }
            set
            {
                if (value < 1900 || value > 2023)
                    throw new ArgumentException("Год выпуска - от 1900 до 2023");
                _yearOfRelease = value;
            }
        }

        public float Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value < 0 || value > 10)
                    throw new ArgumentException("Значение рейтинга должно быть от 0 до 10");
                _rating = value;
            }
        }
    }
}
