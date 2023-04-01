using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Programming.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            object[] enums = new object[] { typeof(Color), typeof(EducationForm), typeof(Genre), typeof(Manufactures), typeof(Season), typeof(Weekday) };
            //создаем массив с названиями пееречислений
            AllEnumsListBox.Items.AddRange(enums); //передаем массив со значениями в AllEnumsListBox
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            var selectedEnum = (Type)AllEnumsListBox.Items[0];
            //выбранное значение по умолчанию - 0
            var enumValues = Enum.GetValues(selectedEnum);
            //массив со значениями перечисления
            foreach (var enumValue in Enum.GetValues(selectedEnum))
            {
                EnumValuesListBox.Items.Add(enumValue);
            }
            //добавляем значения в EnumValuesListBox
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
          
            foreach (var enumValue in enumValues)
            {
                if (text == enumValue.ToString())
                {
                    ParseLabel.Text = $"Это день недели ({enumValue} = {(int)Enum.Parse(typeof(Weekday), enumValue.ToString())}) ";
                }
                    
            }
        }


    }
}
