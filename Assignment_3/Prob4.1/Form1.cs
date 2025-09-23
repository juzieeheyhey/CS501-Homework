using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtInput.Text, out int num))
            {
                MessageBox.Show("Invalid input. Please enter an integer."); // throw error message if input is not an integer
                return;
            }
            if (num < 1 || num > 10)
            {
                MessageBox.Show("Please enter a number between 1 and 10."); // throw error message if input is out of range
                return;
            }
            else
            {
                string[] romanNumerals = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" }; // array of roman numerals from 1 to 10
                txtOutput.Text = romanNumerals[num - 1]; // display the corresponding roman numeral in the output textbox
            }
        }
    }
}
