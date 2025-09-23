namespace Prob5._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const double RISE_PER_YEAR = 1.5; // in mm
        private int year = 10;
        
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= year; i++)
            {
                double rise = i * RISE_PER_YEAR;
                lstDisplay.Items.Add($"After {i} years, the sea level will have risen {rise} mm.");
            }
        }
    }
}
