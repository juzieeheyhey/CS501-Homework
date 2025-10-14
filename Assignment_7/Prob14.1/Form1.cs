using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prob14._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            // read each line as an int from random.txt
            List<int> numbers = File.ReadAllLines("random.txt")
                                    .Select(line => int.Parse(line.Trim()))
                                    .ToList();

            // remove all negative numbers
            numbers.RemoveAll(n => n < 0);

            // create a new list with numbers in the range 1 to 10, and display them in listBox2
            List<int> answer = numbers.FindAll(n => n >= 1 && n <= 10);
            listBox2.DataSource = null;
            listBox2.DataSource = answer;
        }
    }
}
