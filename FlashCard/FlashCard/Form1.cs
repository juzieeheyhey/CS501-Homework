using System.Reflection.Metadata;

namespace FlashCard
{
    public partial class Form1 : Form
    {
        // init private variables here
        private readonly Random random = new Random();
        private const int totalQuestions = 10;

        private int _qIndex = 0;
        private int _attempts = 0;
        private int _score = 0;
        private bool _creditGiven = false;

        private int _topNumber;
        private int _bottomNumber;
        private char _op;
        private int _answer;
        public Form1()
        {
            InitializeComponent();
            this.Shown += (_, __) => StartNewSet(); // syntax found online for on-start call
            this.AcceptButton = btnSubmit; // make enter key trigger submit button
            lblMessage.Text = string.Empty;
            btnSubmit.Enabled = false;
        }

        // Appropriately adjusts counters on the form
        private void UpdateCounters()
        {
            lblQACounter.Text = $"Q {_qIndex + 1}/{totalQuestions}";
            lblAttemptCounter.Text = $"Attempts: {_attempts}/3";
        }

        // Resets all counters and starts a new set of questions
        private void StartNewSet()
        {
            _qIndex = 0;
            _score = 0;
            _attempts = 0;
            NextQuestion();
        }

        private void NextQuestion()
        {
            // Reset attempts and credit for new question
            _attempts = 0;
            _creditGiven = false;
            txtAnswer.Clear();
            txtAnswer.Focus();

            // Randomly decide addition or subtraction
            bool isAdd = random.Next(2) == 0;
            _op = isAdd ? '+' : '-';

            // Generates numbers and ensures no negative results for subtraction
            int a = random.Next(0, 100);
            int b = random.Next(0, 100);
            if (!isAdd && a < b) (a, b) = (b, a);

            _topNumber = a; _bottomNumber = b;
            _answer = isAdd ? a + b : a - b;

            lblOperandA.Text = _topNumber.ToString();
            lblOperandB.Text = _bottomNumber.ToString();
            lblOperator.Text = _op.ToString();

            UpdateCounters();            // <— refresh Q and attempts (0/3)
        }

        private void CheckAndHandleSubmit()
        {
            bool parsed = int.TryParse(txtAnswer.Text.Trim(), out int guess);
            bool correct = parsed && guess == _answer;

            if (correct)
            {
                if (!_creditGiven) { _score++; _creditGiven = true; }
                lblMessage.Text = "Correct!";
                AdvanceOrFinish();
            }
            else
            {
                _attempts++;
                if (_attempts < 3)
                {
                    // whilte attempts are left, give feedback and allow retry
                    lblMessage.Text = "Incorrect, try again.";
                    txtAnswer.Clear();
                    txtAnswer.Focus();
                    UpdateCounters();    // <— show 1/3 or 2/3
                }
                else
                {
                    // out of attempts, move on
                    lblMessage.Text = "Let's try something different.";
                    AdvanceOrFinish();   // NextQuestion() will reset attempts and counters
                }
            }
        }
        private void AdvanceOrFinish()
        {
            _qIndex++;

            if (_qIndex >= totalQuestions)
            {
                MessageBox.Show($"Score: {_score}/{totalQuestions}", "Results");
                StartNewSet(); // reset for a fresh run
            }
            else
            {
                NextQuestion();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CheckAndHandleSubmit();
        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {
            btnSubmit.Enabled = !string.IsNullOrWhiteSpace(txtAnswer.Text);
        }
    }
}
