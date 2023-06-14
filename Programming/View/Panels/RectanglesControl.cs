﻿using Programming.Model.Classes;
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

namespace Programming.View.Panels
{
    /// <summary>
    /// Предоставляет методы для получения информации о прямоугольниках 
    /// и поиска прямоугольника с наибольшей шириной. 
    /// </summary>
    public partial class RectanglesControl : UserControl
    {
        /// <summary>
        /// Объект типа <see cref="Model.Classes.Geometry.Rectangle"/>. 
        /// </summary>
        private Model.Classes.Geometry.Rectangle _currentRectangle = new Model.Classes.Geometry.Rectangle();
        /// <summary>
        /// Массив объектов типа <see cref="Model.Classes.Geometry.Rectangle"/>. 
        /// </summary>
        private Model.Classes.Geometry.Rectangle[] _rectangles = new Model.Classes.Geometry.Rectangle[5];

        public RectanglesControl()
        {
            InitializeComponent();

            string[] colorNames = Enum.GetNames(typeof(Model.Enums.Color));
            Random rand = new Random();
            for (int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = new Model.Classes.Geometry.Rectangle(Math.Round(rand.NextDouble() * 100, 1),
                    Math.Round(rand.NextDouble() * 100, 1),
                    colorNames[rand.Next(0, colorNames.Length)], rand.Next(1, 100),
                    rand.Next(1, 100));
                RectanglesListBox.Items.Add($"Rectangle {i + 1}");
            }
            
        }

        /// <summary>
        /// Обновляет текстовые поля при выборе прямоугольника.
        /// </summary>
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

        /// <summary>
        /// Проверяет и сохраняет значение из текстового поля при его изменении.
        /// </summary>
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

        /// <summary>
        /// Проверяет и сохраняет значение из текстового поля при его изменении.
        /// </summary>
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

        /// <summary>
        /// Сохраняет значение из текстового поля при его изменении.
        /// </summary>
        private void RectColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = RectColorTextBox.Text;
        }

        /// <summary>
        /// Выбирает прямоугольник с максимальной шириной при нажатии на кнопку. 
        /// </summary>
        private void FindMaxWidthButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth();
        }

        /// <summary>
        /// Ищет прямоугольник с максимальной шириной. 
        /// </summary>
        /// <returns>Возвращает индекс прямоугольника с максимальной шириной. </returns>
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
    }
}
