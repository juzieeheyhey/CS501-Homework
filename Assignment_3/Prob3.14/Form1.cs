namespace Prob3._14
{
    public partial class Form1 : Form
    {
        // Declearing constants for each class ticket price
        private const decimal CLASS_A_PRICE = 15.0m;
        private const decimal CLASS_B_PRICE = 12.0m;
        private const decimal CLASS_C_PRICE = 9.0m;
        // Declearing variables for each class number of tickets sold, initialized to 0
        private int classANumTickets = 0;
        private int classBNumTickets = 0;
        private int classCNumTickets = 0;
        // Declearing variable for each class's revenue, initialized to 0
        private decimal classARevenue = 0.0m;
        private decimal classBRevenue = 0.0m;
        private decimal classCRevenue = 0.0m;
        // Declearing variable for total revenue, initialized to 0
        private decimal totalRevenue = 0.0m;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Get number of tickets sold for each class from user input
            classANumTickets = int.Parse(txtTicketA.Text);
            classBNumTickets = int.Parse(txtTicketB.Text);
            classCNumTickets = int.Parse(txtTicketC.Text);
            // Calculate revenue for each class
            classARevenue = classANumTickets * CLASS_A_PRICE;
            classBRevenue = classBNumTickets * CLASS_B_PRICE;
            classCRevenue = classCNumTickets * CLASS_C_PRICE;
            // Calculate total revenue
            totalRevenue = classARevenue + classBRevenue + classCRevenue;
            // Display revenue for each class and total revenue in currency format
            txtClassARevenue.Text = classARevenue.ToString("C");
            txtClassBRevenue.Text = classBRevenue.ToString("C");
            txtClassCRevenue.Text = classCRevenue.ToString("C");
            txtTotalRevenue.Text = totalRevenue.ToString("C");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Reseting all variables to initial values
            classANumTickets = 0;
            classBNumTickets = 0;
            classCNumTickets = 0;
            classARevenue = 0.0m;
            classBRevenue = 0.0m;
            classCRevenue = 0.0m;
            totalRevenue = 0.0m;
            // Clear all text boxes
            txtTicketA.Clear();
            txtTicketB.Clear();
            txtTicketC.Clear();
            txtClassARevenue.Clear();
            txtClassBRevenue.Clear();
            txtClassCRevenue.Clear();
            txtTotalRevenue.Clear();
          
        }
    }
}
