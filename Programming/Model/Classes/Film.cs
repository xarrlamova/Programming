using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит информацию о фильме.
    /// </summary>
    public class Film
    {
        /// <summary>
        /// Возвращает и задает название фильма.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Длительность фильма в минутах.
        /// </summary>
        private int _durationInMinutes;

        /// <summary>
        /// Год релиза фильма.
        /// </summary>
        private int _yearOfRelease;

        /// <summary>
        /// Возвращает и задает жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Возвращает и задает длительность фильма в минутах. Должно быть положительным.
        /// </summary>
        public int DurationInMinutes
        {
            get { return _durationInMinutes; }
            set 
            {
                Validator.AssertOnPositiveValue(value, nameof(DurationInMinutes));
                _durationInMinutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задает год релиза. Должен быть от 1900 до текущего года.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает рейтинг. Должен находиться в диапозоне от 0 до 10.
        /// </summary>
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

        /// <summary>
        /// Создает объект класса <see cref="Film"/>.
        /// </summary>
        public Film()
        {

        }
        /// <summary>
        /// Создает объект класса <see cref="Film"/>.
        /// </summary>
        /// <param name="title">Название фильма.</param>
        /// <param name="durationInMinutes">Длительность в минутах. Должна быть положительной.</param>
        /// <param name="yearOfRelease">Год релиза. Должен входить в диапазон от 1900 до текущего года.</param>
        /// <param name="genre">Жанр.</param>
        /// <param name="rating">Рейтинг. Должен быть в диапазоне от 0 до 10.</param>
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
