using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prob3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnURL_Click(object sender, EventArgs e)
        {
            string url = tbURL.Text.Trim();

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Please enter a valid URL.");
                return;
            }

            try
            {
                wbURL.Navigate(url);
            }
            catch
            {
                 MessageBox.Show("Failed to navigate to the URL.");
            }

        }

        private void btnQR_Click(object sender, EventArgs e)
        {
            string url = tbURL.Text.Trim();

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Please enter a valid URL.");
                return;
            }

            QRCodeGenerator qrGen = new QRCodeGenerator();
            QRCodeData qrData = qrGen.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrData);

            Bitmap qrImage = qrCode.GetGraphic(20);
            pbQR.Image = qrImage;
        }
    }
}
