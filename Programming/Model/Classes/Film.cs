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
        private double _rating;


        public int DurationInMinutes
        {
            get { return _durationInMinutes; }
            set 
            {
                Validator.AssertOnPositiveValue(value, nameof(DurationInMinutes));
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
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, nameof(YearOfRelease));
                _yearOfRelease = value;
            }
        }

        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
                _rating = value;
            }
        }

        public Film()
        {

        }

        public Film(string title, int durationInMinutes, int yearOfRelease, string genre, double rating)
        {
            Title = title;
            DurationInMinutes = durationInMinutes;
            YearOfRelease = yearOfRelease;
            Genre = genre;
            Rating = rating;
        }

    }
}
