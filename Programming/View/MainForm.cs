using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Enums;


namespace Programming.View
{
    public partial class MainForm : Form
    {
        private Model.Classes.Rectangle[] _rectangles = new Model.Classes.Rectangle[5];
        private Model.Classes.Rectangle _currentRectangle = new Model.Classes.Rectangle();
       
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

            AllEnumsListBox.Items.AddRange(enums); //передаем массив со значениями в AllEnumsListBox
            AllEnumsListBox.DisplayMember = nameof(Type.Name);

            Random _rand = new Random();
            for(int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = new Model.Classes.Rectangle(Math.Round(_rand.NextDouble() * 100, 1),
                    Math.Round(_rand.NextDouble() * 100, 1),
                    colorNames[_rand.Next(0, colorNames.Length)], _rand.Next(1, 100),
                    _rand.Next(1, 100));
                RectanglesListBox.Items.Add($"Rectangle {i + 1}");
            }
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            var selectedEnum = (Type)AllEnumsListBox.Items[0];
            //выбранное значение по умолчанию - 0
            foreach (var enumValue in Enum.GetValues(selectedEnum))
            {
                EnumValuesListBox.Items.Add(enumValue);
            }
            //добавляем значения в EnumValuesListBox

            SeasonComboBox.Items.AddRange(Enum.GetNames(typeof(Season)));
        }
        private void AllEnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedEnum = (Type)AllEnumsListBox.SelectedItem;
            //выбранное значение - то, что кликнул пользователь

            var enumValues = Enum.GetValues(selectedEnum);
            //создаем массив enumValues со значениями перечисления
            EnumValuesListBox.Items.Clear();
            //Очищаем EnumValuesListBox от прошлых перечислений
            foreach (var enumValue in enumValues)
            {
                EnumValuesListBox.Items.Add(enumValue);
            }
            //добавляем значения перечислений в EnumValuesListBox
        }

        private void EnumValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedEnum = (int)EnumValuesListBox.SelectedItem;
            //выбранное значение - то, что кликнул пользователь
            ValueIntTextBox.Text = selectedEnum.ToString();
            //заносим числовое значение выбранного во втором списке в ValueTextBox
        }


        private void ParseButton_Click(object sender, EventArgs e)
        {
            if (ParsingValueTextBox.Text == "") return;
            //если ParsingValueTextBox пустой прекращение работы
            string text = ParsingValueTextBox.Text;
            var enumValues = Enum.GetValues(typeof(Weekday));

            var flag = false;
            foreach (var enumValue in enumValues)
            {
                if (text == enumValue.ToString())
                {
                    flag = true;
                    int IndexValue = (int)Enum.Parse(typeof(Weekday), enumValue.ToString());
                    ParseLabel.Text = $"Это день недели ({enumValue} = {IndexValue}) ";
                }
                    
            }
            if (!flag) ParseLabel.Text = "Нет такого дня недели";
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            switch (SeasonComboBox.Text)
            {
                case "Spring":
                    SeasonHandleGroupBox.BackColor = System.Drawing.Color.Green;
                    break;
                case "Summer":
                    SeasonHandleGroupBox.BackColor = System.Drawing.Color.White;
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case "Autumn":
                    SeasonHandleGroupBox.BackColor = System.Drawing.Color.Orange;
                    break;
                case "Winter":
                    SeasonHandleGroupBox.BackColor = System.Drawing.Color.White;
                    MessageBox.Show("Бррр! Холодно!");
                    break;

            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[value];
            RectWidthTextBox.Text = _currentRectangle.Width.ToString();
            RectLengthTextBox.Text = _currentRectangle.Length.ToString();
            RectColorTextBox.Text = _currentRectangle.Color.ToString();
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

        private void FindMaxWidthButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth();
        }
    }
}
