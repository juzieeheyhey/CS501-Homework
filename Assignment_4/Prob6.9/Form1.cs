namespace Prob6._9
{
    public partial class Form1 : Form
    {
        private enum Choice
        {
            Rock = 1,
            Paper = 2,
            Scissors = 3
        }


        private Choice ComputerChoice;
        public Form1()
        {
            InitializeComponent();
        }

        private void StartNewRound()
        {
            picRock.Enabled = true;
            picPaper.Enabled = true;
            picScissors.Enabled = true;
            ComputerChoice = GenerateComputerChoice();
            lblStartMessage.Text = "Computer has made its choice.";
            lblMessage.Text = "Your turn - Choose Rock, Paper, or Scissors!";
            lblResult.Text = "";
           


        }

        private void disableRest(Choice userChoice)
        {
            if (userChoice == Choice.Rock)
            {
                picPaper.Enabled = false;
                picScissors.Enabled = false;
            }
            else if (userChoice == Choice.Paper)
            {
                picRock.Enabled = false;
                picScissors.Enabled = false;
            }
            else if (userChoice == Choice.Scissors)
            {
                picRock.Enabled = false;
                picPaper.Enabled = false;
            }
        }

        private Choice GenerateComputerChoice()
        {
            Random rand = new Random();
            int choice = rand.Next(1, 4); // Generates a number between 1 and 3
            switch (choice)
            {
                case 1:
                    return Choice.Rock;

                case 2:
                    return Choice.Paper;
                case 3:
                    return Choice.Scissors;
                default:
                    return Choice.Rock; // Default case, should not occur
            }
        }

        private void PlayTurn(Choice userChoice)
        {
            disableRest(userChoice);
            decideWinner(userChoice, ComputerChoice);
        }

        private void decideWinner(Choice userChoice, Choice computerChoice)
        {
            lblMessage.Text = $"Computer chose {computerChoice}. You chose {userChoice}. ";
            if (userChoice == computerChoice)
            {
                lblResult.Text = "It's a tie!";
            }
            else if ((userChoice == Choice.Rock && computerChoice == Choice.Scissors) ||
                     (userChoice == Choice.Paper && computerChoice == Choice.Rock) ||
                     (userChoice == Choice.Scissors && computerChoice == Choice.Paper))
            {
                lblResult.Text = "You win!";
            }
            else
            {
                lblResult.Text = "Computer wins!";
            }
        }

        private void picRock_Click(object sender, EventArgs e)
        {
            PlayTurn(Choice.Rock);
        }

        private void picPaper_Click(object sender, EventArgs e)
        {
            PlayTurn(Choice.Paper);
        }

        private void picScissors_Click(object sender, EventArgs e)
        {
            PlayTurn(Choice.Scissors);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartNewRound();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            StartNewRound();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
