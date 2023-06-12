using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Classes;
using Programming.Model.Classes.Geometry;
using Programming.Model.Enums;


namespace Programming.View
{
    public partial class MainForm : Form
    {
        private Model.Classes.Geometry.Rectangle[] _rectangles = new Model.Classes.Geometry.Rectangle[5];
        private Model.Classes.Geometry.Rectangle _currentRectangle = new Model.Classes.Geometry.Rectangle();
        private Film[] _films = new Film[5];
        private Film _currentFilm = new Film();


        public MainForm()
        {
            InitializeComponent();

            object[] enums = new object[] 
            {
                typeof(Model.Enums.Color),
                typeof(EducationForm),
                typeof(Genre),
                typeof(Manufactures),
                typeof(Season),
                typeof(Weekday)
            };

            string[] colorNames = Enum.GetNames(typeof(Model.Enums.Color));
            string[] filmNames = Enum.GetNames(typeof(FilmNames));
            string[] filmGenres = Enum.GetNames(typeof(Genre));

            

            Random rand = new Random();
            for(int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = new Model.Classes.Geometry.Rectangle(Math.Round(rand.NextDouble() * 100, 1),
                    Math.Round(rand.NextDouble() * 100, 1),
                    colorNames[rand.Next(0, colorNames.Length)], rand.Next(1, 100),
                    rand.Next(1, 100));
                RectanglesListBox.Items.Add($"Rectangle {i + 1}");
            }
            for (int i = 0; i < _films.Length; i++)
            {
                _films[i] = new Film(filmNames[rand.Next(1, filmNames.Length)], rand.Next(300), rand.Next(1900, 2023),
                    filmGenres[rand.Next(1, filmGenres.Length)], Math.Round(rand.NextDouble() * 10, 1));
                FilmsListBox.Items.Add($"Film {i + 1}");
            }
        }
        

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[value];
            RectWidthTextBox.Text = _currentRectangle.Width.ToString();
            RectLengthTextBox.Text = _currentRectangle.Length.ToString();
            RectColorTextBox.Text = _currentRectangle.Color.ToString();

            RectXTextBox.Text = _currentRectangle.Centre.X.ToString();
            RectYTextBox.Text = _currentRectangle.Centre.Y.ToString();
            RectIDTextBox.Text = _currentRectangle.Id.ToString();

            RectLengthTextBox.TextChanged += RectLengthTextBox_TextChanged;
            RectWidthTextBox.TextChanged += RectWidthTextBox_TextChanged;
            RectColorTextBox.TextChanged += RectColorTextBox_TextChanged;
        }

        private void RectWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double newWidth = Convert.ToDouble(RectWidthTextBox.Text);
                _currentRectangle.Width = newWidth;
                RectWidthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                RectWidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }


        private void RectLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double newLength = Convert.ToDouble(RectLengthTextBox.Text);
                _currentRectangle.Length = newLength;
                RectLengthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                RectLengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void RectColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = RectColorTextBox.Text;
        }

        private int FindRectangleWithMaxWidth()
        {
            double maxWidth = _rectangles[0].Width;
            int maxWidthIndex = 0;

            for (int i = 0; i < _rectangles.Length; i++)
            {
                if (_rectangles[i].Width > maxWidth)
                {
                    maxWidth = _rectangles[i].Width;
                    maxWidthIndex = i;
                }
            }
            return maxWidthIndex;
        }


        private void FilmsListBox_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void FindMaxWidthButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth();
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

        private void FilmGenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Genre = FilmGenreTextBox.Text;
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

        private void ValueIntTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SeasonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RectXTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RectYTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RectIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
