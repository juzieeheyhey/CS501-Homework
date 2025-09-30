using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prob7._10
{
    public partial class Form1 : Form
    {
        // Add these fields to the Form1 class to store totals across method calls
        private decimal totalAmount = 0;
        private decimal totalWon = 0;
        private static readonly Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtInput.Text, out decimal amount))
            {
                MessageBox.Show("Please enter a valid amount."); // check for numeric entries
                return;
            }
            if (amount <= 0)
            {
                MessageBox.Show("Please enter a number greater than 0."); // check for positive entries
                return;
            }

            totalAmount += amount;

            int count = imgList.Images.Count; // number of images

            // generate random numbers for images

            int n1 = random.Next(0, count);
            int n2 = random.Next(0, count);
            int n3 = random.Next(0, count);

            picBox1.Image = imgList.Images[n1];
            picBox2.Image = imgList.Images[n2];
            picBox3.Image = imgList.Images[n3];

            int multi = 0;
            if (n1 == n2 && n2 == n3) // 3 images mathc
            {
                multi = 3;
            }
            else if (n1 == n2 || n2 == n3 || n3 == n1) // any 2 images match
            {
                multi = 2;
            }

            decimal won = amount * multi; // amount won
            totalWon += won; // total won
            lblOutput.Text = "You won $ " + won.ToString("F2") + " this round.";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Total amount of money entered: $ " + totalAmount.ToString("F2") +
                "\nTotal amount won: $ " + totalWon.ToString("F2")
            );
            Close();
        }
    }
}
