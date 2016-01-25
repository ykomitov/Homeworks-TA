namespace _05.Calculator
{
    using System;
    using System.Web.UI.WebControls;

    public partial class Calculator : System.Web.UI.Page
    {
        private const string ErrorMessage = "Error!";
        private static string currentOpperation = string.Empty;
        private static double firstNumber;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Calc_UpdateDisplay(object sender, EventArgs e)
        {
            if (this.CalculatorDisplay.Text == ErrorMessage)
            {
                this.CalculatorDisplay.Text = string.Empty;
            }

            Button currentButton = sender as Button;
            string currentDisplay = this.CalculatorDisplay.Text;
            string pressedButtonText = currentButton.Text;
            this.CalculatorDisplay.Text = currentDisplay + pressedButtonText;
        }

        protected void Calc_Operation(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            currentOpperation = currentButton.Text;

            if (this.CalculatorDisplay.Text == string.Empty)
            {
                return;
            }

            firstNumber = double.Parse(this.CalculatorDisplay.Text);
            this.CalculatorDisplay.Text = string.Empty;
        }

        protected void Calc_Clear_Click(object sender, EventArgs e)
        {
            this.CalculatorDisplay.Text = string.Empty;
        }

        protected void Calc_Sqrt_Click(object sender, EventArgs e)
        {
            double result;

            try
            {
                firstNumber = double.Parse(this.CalculatorDisplay.Text);

                if (firstNumber < 0)
                {
                    throw new Exception();
                }

                result = Math.Sqrt(firstNumber);
                this.CalculatorDisplay.Text = result.ToString();
                firstNumber = 0;
            }
            catch (Exception)
            {
                this.CalculatorDisplay.Text = ErrorMessage;
                firstNumber = 0;
            }
        }

        protected void CalculatorEquals_Click(object sender, EventArgs e)
        {
            if (this.CalculatorDisplay.Text == string.Empty)
            {
                return;
            }

            double secondNumber = double.Parse(this.CalculatorDisplay.Text);

            if (currentOpperation == "+")
            {
                var result = firstNumber + secondNumber;
                this.CalculatorDisplay.Text = result.ToString();
                firstNumber = 0;
            }
            else if (currentOpperation == "-")
            {
                var result = firstNumber - secondNumber;
                this.CalculatorDisplay.Text = result.ToString();
                firstNumber = 0;
            }
            else if (currentOpperation == "X")
            {
                var result = firstNumber * secondNumber;
                this.CalculatorDisplay.Text = result.ToString();
                firstNumber = 0;
            }
            else if (currentOpperation == "/")
            {
                var result = firstNumber / secondNumber;
                this.CalculatorDisplay.Text = result.ToString();
                firstNumber = 0;
            }
            else
            {
                this.CalculatorDisplay.Text = ErrorMessage;
                firstNumber = 0;
            }
        }
    }
}