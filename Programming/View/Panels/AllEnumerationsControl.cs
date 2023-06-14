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
    ///  Предоставляет методы для вывода данных в листбоксы и текстбокс. 
    /// </summary>
    public partial class AllEnumerationsControl : UserControl
    {
        public AllEnumerationsControl()
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

            var selectedEnum = (Type)AllEnumsListBox.Items[0];
            //выбранное значение по умолчанию - 0
            foreach (var enumValue in Enum.GetValues(selectedEnum))
            {
                EnumValuesListBox.Items.Add(enumValue);
            }
            //добавляем значения в EnumValuesListBox
        }
        /// <summary>
        /// Заполняет один листбокс в зависимости от выбранного значения в другом.
        /// </summary>
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
        /// <summary>
        /// Выводит индекс выбранного элемента перечисления в текстовое поле. 
        /// </summary>
        private void EnumValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedEnum = (int)EnumValuesListBox.SelectedItem;
            //выбранное значение - то, что кликнул пользователь
            ValueIntTextBox.Text = selectedEnum.ToString();
            //заносим числовое значение выбранного во втором списке в ValueTextBox
        }
    }
}
