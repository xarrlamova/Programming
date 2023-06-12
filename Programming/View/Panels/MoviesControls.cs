using Programming.Model.Classes;
using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Programming.View.Panels
{
    public partial class MoviesControls : UserControl
    {
        private Film[] _films = new Film[5];
        private Film _currentFilm = new Film();

        public MoviesControls()
        {
            InitializeComponent();

            string[] filmNames = Enum.GetNames(typeof(FilmNames));
            string[] filmGenres = Enum.GetNames(typeof(Genre));

            Random rand = new Random();
            for (int i = 0; i < _films.Length; i++)
            {
                _films[i] = new Film(filmNames[rand.Next(1, filmNames.Length)], rand.Next(300), rand.Next(1900, 2023),
                filmGenres[rand.Next(1, filmGenres.Length)], Math.Round(rand.NextDouble() * 10, 1));
                FilmsListBox.Items.Add($"Film {i + 1}");
            }
        }

        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = FilmsListBox.SelectedIndex;
            _currentFilm = _films[value];
            FilmNameTextBox.Text = _currentFilm.Title;
            FilmDurationTextBox.Text = _currentFilm.DurationInMinutes.ToString();
            FilmYearTextBox.Text = _currentFilm.YearOfRelease.ToString();
            FilmGenreTextBox.Text = _currentFilm.Genre;
            FilmRatingTextBox.Text = _currentFilm.Rating.ToString();
            FilmNameTextBox.TextChanged += FilmNameTextBox_TextChanged;
            FilmDurationTextBox.TextChanged += FilmDurationTextBox_TextChanged;
            FilmYearTextBox.TextChanged += FilmYearTextBox_TextChanged;
            FilmGenreTextBox.TextChanged += FilmGenreTextBox_TextChanged;
            FilmRatingTextBox.TextChanged += FilmRatingTextBox_TextChanged;
        }

        private void FilmNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Title = FilmNameTextBox.Text;
        }

        private void FilmDurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int newDuration = Convert.ToInt32(FilmDurationTextBox.Text);
                _currentFilm.DurationInMinutes = newDuration;
                FilmDurationTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                FilmDurationTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void FilmYearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int newYear = Convert.ToInt32(FilmYearTextBox.Text);
                _currentFilm.YearOfRelease = newYear;
                FilmYearTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                FilmYearTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void FilmGenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Genre = FilmGenreTextBox.Text;
        }

        private void FilmRatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double newRating = Convert.ToDouble(FilmRatingTextBox.Text);
                _currentFilm.Rating = newRating;
                FilmRatingTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                FilmRatingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void FindMaxFilmRatingButton_Click(object sender, EventArgs e)
        {
            FilmsListBox.SelectedIndex = FindFilmWithMaxRating();
        }

        private int FindFilmWithMaxRating()
        {
            double maxRating = _films[0].Rating;
            int maxRatingIndex = 0;

            for (int i = 0; i < _films.Length; i++)
            {
                if (_films[i].Rating > maxRating)
                {
                    maxRating = _films[i].Rating;
                    maxRatingIndex = i;
                }
            }
            return maxRatingIndex;
        }
    }
}
