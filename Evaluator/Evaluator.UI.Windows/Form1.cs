using Evaluator.Core;


namespace Evaluator.UI.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += ",";
        }

        private void btnOpenParentesis_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += "(";
        }

        private void btnCloseParentesis_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += ")";
        }

        private void btnMutiply_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += "/";
        }

        private void btnPus_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += "-";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += $"={ExpressionEvaluator.Evaluate(TxtDisplay.Text)}";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text.Substring(0, TxtDisplay.Text.Length -1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = string.Empty; 
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text += "^";

        }
    }
}
