namespace Prob3._10
{
    public partial class Form1 : Form
    {
        // Setting the price of fruits
        private const decimal BANANA_PRICE = 0.65m;
        private const decimal APPLE_PRICE = 1.35m;
        private const decimal ORANGE_PRICE = 1.60m;
        private const decimal PEAR_PRICE = 1.20m;

        // decalaring variable for total price
        private decimal totalPrice = 0.0m;
        public Form1()
        {
            InitializeComponent();
            txtDisplayTotal.Text = totalPrice.ToString("C");
        }

        private void picBanana_Click(object sender, EventArgs e)
        {
            totalPrice += BANANA_PRICE; // Add banana price to total when user clicks on banana picture
            txtDisplayTotal.Text = totalPrice.ToString("C"); // Display total price in currency format
        }

        private void picApple_Click(object sender, EventArgs e)
        {
            totalPrice += APPLE_PRICE; // Add apple price to total when user clicks on apple picture
            txtDisplayTotal.Text = totalPrice.ToString("C");
        }

        private void picOrange_Click(object sender, EventArgs e)
        {
            totalPrice += ORANGE_PRICE; // Add orange price to total when user clicks on orange picture
            txtDisplayTotal.Text = totalPrice.ToString("C");
        }

        private void picPear_Click(object sender, EventArgs e)
        {
            totalPrice += PEAR_PRICE; // Add pear price to total when user clicks on pear picture
            txtDisplayTotal.Text = totalPrice.ToString("C");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            totalPrice = 0.0m; // Reset total price to 0 when user clicks on reset button
            txtDisplayTotal.Text = totalPrice.ToString("C");
        }
    }
}
