// Name: Brandon Benavides
// Project: Calculator
// A simple calculator application


namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int numberOne, numberTwo, Answer;
        
        private void convertFormula()
        {
            // Check if a numeric value was entered otherwise let user know to enter a number
            try
            {
                // Convert number entered into an integer from string
                    numberOne = Convert.ToInt32(txtNumberOne.Text);
                    numberTwo = Convert.ToInt32(txtNumberTwo.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Enter a number.");
                txtNumberOne.Text = "";
                txtNumberOne.Focus();
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            convertFormula();

            // Addition of both variables
            Answer = numberOne + numberTwo;

            // Display answer to addition
            lblAnswer.Text = Answer.ToString();
            lblAnswer.Visible = true;

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            convertFormula();
            // Subtraction Formula
            Answer = numberOne - numberTwo;

            // Display answer
            lblAnswer.Text = Answer.ToString();
            lblAnswer.Visible = true;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            convertFormula();

            // Multiplication Formula
            Answer = numberOne * numberTwo;

            // Display Answer
            lblAnswer.Text = Answer.ToString();
            lblAnswer.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            convertFormula();

            // Divisioon Formula
            Answer = numberOne / numberTwo;

            // Display Answer
            lblAnswer.Text = Answer.ToString();
            lblAnswer.Visible = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clears all fields
            txtNumberOne.Text = "";
            txtNumberTwo.Text = "";
            lblAnswer.Text = "";
            lblAnswer.Visible = false;

            txtNumberOne.Focus();

            numberOne = 0;
            numberTwo = 0;
        }
    }
}