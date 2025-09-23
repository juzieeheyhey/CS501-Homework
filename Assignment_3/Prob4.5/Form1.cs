using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem4_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtInput.Text, out int number))
            {
                MessageBox.Show("Please enter a valid integer."); // throw error message if input is not an integer
                return;
            }

            if (lbFrom.SelectedItem == null || lbTo.SelectedItem == null)
            {
                MessageBox.Show("Please select both conversion types."); // throw error message if conversion types are not selected
                return;
            }

            string from = lbFrom.SelectedItem.ToString();
            string to = lbTo.SelectedItem.ToString();
            double input = double.Parse(txtInput.Text);

            if (from == to) // no conversion needed
            {
                txtOutput.Text = input.ToString();
                return;
            }
            else if (from  == "Inches" && to == "Feet") // inches to feet
            {
                double feet = input / 12;
                txtOutput.Text = feet.ToString("F2");
            }
            else if (from == "Inches" && to == "Yards") // inches to yards
            {
                double yards = input / 36;
                txtOutput.Text = yards.ToString("F2");
            }
            else if (from == "Feet" && to == "Inches") // feet to inches
            {
                double inches = input * 12;
                txtOutput.Text = inches.ToString("F2");
            }
            else if (from == "Feet" && to == "Yards") // feet to yards
            {
                double yards = input / 3;
                txtOutput.Text = yards.ToString("F2");
            }
            else if (from == "Yards" && to == "Inches") // yards to inches
            {
                double inches = input * 36;
                txtOutput.Text = inches.ToString("F2");
            }
            else if (from == "Yards" && to == "Feet") // yards to feet
            {
                double feet = input * 3;
                txtOutput.Text = feet.ToString("F2");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // close the form
        }
    }
}
