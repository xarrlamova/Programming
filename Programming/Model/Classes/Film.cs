using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Film
    {
        public string Title { get; set; }
        private int _durationInMinutes;
        private int _yearOfRelease;
        public string Genre { get; set; }
        private float _rating;


        public int DurationInMinutes
        {
            get { return _durationInMinutes; }
            set 
            {
                if (_durationInMinutes <= 0)
                    throw new ArgumentException("Продолжительность в минутах должна быть больше нуля");
                _durationInMinutes = value; 
            }
        }

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
