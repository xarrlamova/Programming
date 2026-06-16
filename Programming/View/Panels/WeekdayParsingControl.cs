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
    /// Предоставляет методы для проверки наличия в перечислении 
    /// с днями недели вводимой строки в текстовом поле. 
    /// </summary>
    public partial class WeekdayParsingControl : UserControl
    {
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Проверяет вводимое значение на его наличие среди перечисления дней недели
        /// </summary>
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
                    int indexValue = (int)Enum.Parse(typeof(Weekday), enumValue.ToString());
                    ParseLabel.Text = $"Это день недели ({enumValue} = {indexValue}) ";
                }

            }
            if (!flag) ParseLabel.Text = "Нет такого дня недели";
        }
    }


}
