namespace Prob5._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int input = int.Parse(txtInput.Text); 
                if (input < 0)
                {
                    // Make sure input is a non-negative integer
                    MessageBox.Show("Please enter a positive integer.");
                    return;
                }
                int factorial = 1;
                for (int i = 1; i <= input; i++)
                {
                    // A for loop to calculate factorial
                    factorial *= i;
                }
                lblResult.Text = $"Factorial of {input} is {factorial}."; // Display the result

            }
            catch (FormatException) 
            {
                // Handle non-integer inputs
                MessageBox.Show("Invalid input. Please enter a valid integer.");
                return;
            }
            catch (OverflowException)
            {
                // Handle inputs that are too large
                MessageBox.Show("Input is too large. Please enter a smaller integer.");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
                return;
            }
        }
    }
}
