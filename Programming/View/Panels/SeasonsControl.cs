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
    public partial class SeasonsControl : UserControl
    {
        public SeasonsControl()
        {
            InitializeComponent();

            SeasonComboBox.Items.AddRange(Enum.GetNames(typeof(Season)));
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
