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
        public MainForm()
        {
            InitializeComponent();

            object[] enums = new object[] 
            {
                typeof(Programming.Model.Enums.Color),
                typeof(EducationForm),
                typeof(Genre),
                typeof(Manufactures),
                typeof(Season),
                typeof(Weekday)
            };

            //создаем массив с названиями пееречислений
            AllEnumsListBox.Items.AddRange(enums); //передаем массив со значениями в AllEnumsListBox
            AllEnumsListBox.DisplayMember = nameof(Type.Name);
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
    }
}
