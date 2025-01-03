namespace Scientific_Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        string optr="";
        double firstDigit;
        double secondDigit;
        double finalresult;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void displaybox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + ".";
                }

            }
            else
            {
                textBox1.Text = textBox1.Text + button.Text;
            }

        }

        private void button29_Click(object sender, EventArgs e)
        {
            int index = textBox1.Text.Length;
            index--;
            textBox1.Text = textBox1.Text.Remove(index);

            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            displaybox.Text = "";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            double re = double.Parse(textBox1.Text);
            re = re * -1;
            textBox1.Text = re.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button op = (Button)sender;
            displaybox.Text = textBox1.Text + op.Text;
            optr = op.Text;
            firstDigit = double.Parse(textBox1.Text);
            textBox1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {

            secondDigit = double.Parse(textBox1.Text);
            switch (optr)
            {
                case "+":
                    finalresult = firstDigit + secondDigit;
                    break;
                case "-":
                    finalresult = firstDigit - secondDigit;
                    break;
                case "*":
                    finalresult = firstDigit * secondDigit;
                    break;
                case "/":
                    if (secondDigit == 0)
                    {
                        MessageBox.Show("The second number can not be zero");
                        return;
                    }
                    finalresult = firstDigit / secondDigit;
                    break;
                case "^":
                    finalresult = Math.Pow(firstDigit, secondDigit);
                    break;

            }
            if (!displaybox.Text.Contains("="))
            {
                displaybox.Text = displaybox.Text + secondDigit.ToString() + "=";
                textBox1.Text = finalresult.ToString();
            }


        }

        private void button15_Click(object sender, EventArgs e)
        {
            Double sqr = double.Parse(textBox1.Text);
            finalresult = sqr * sqr;
            displaybox.Text = "Sqr(" + sqr + ")" + "=";
            textBox1.Text = finalresult.ToString();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double re = double.Parse(textBox1.Text);
            displaybox.Text = "√(" + re + ")" + "=";
            finalresult = Math.Sqrt(re);
            textBox1.Text = finalresult.ToString();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            double re = double.Parse(textBox1.Text);
            displaybox.Text = "|" + re + "|" + "=";
            finalresult = Math.Abs(re);
            textBox1.Text = finalresult.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double re = double.Parse(textBox1.Text);
            displaybox.Text = "log₁₀(" + re + ")" + "=";
            finalresult = Math.Log10(re);
            textBox1.Text = finalresult.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double re = double.Parse(textBox1.Text);
            displaybox.Text = "Sin(" + re + ")" + "=";
            finalresult = Math.Sin(re);
            textBox1.Text = finalresult.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double re = double.Parse(textBox1.Text);
            displaybox.Text = "Cos(" + re + ")" + "=";
            finalresult = Math.Cos(re);
            textBox1.Text = finalresult.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double re = double.Parse(textBox1.Text);
            displaybox.Text = "tan(" + re + ")" + "=";
            finalresult = Math.Tan(re);
            textBox1.Text = finalresult.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += Math.PI;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double re = double.Parse(textBox1.Text);
            displaybox.Text = "1/" + re + "=";
            finalresult = 1 / re;
            textBox1.Text = finalresult.ToString();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            double re = double.Parse(textBox1.Text);
            displaybox.Text = "exp(" + re + ")" + "=";
            finalresult = Math.Exp(re);
            textBox1.Text = finalresult.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double re = double.Parse(textBox1.Text);
            displaybox.Text = "ln(" + re + ")" + "=";
            finalresult = Math.Log(re, Math.E);
            textBox1.Text = finalresult.ToString();
        }

        private void button34_Click(object sender, EventArgs e)
        {


        }

        private void button31_Click(object sender, EventArgs e)
        {
            double re = double.Parse(textBox1.Text);
            displaybox.Text = "Sec(" + re + ")" + "=";
            finalresult = 1 / Math.Cos(re);
            textBox1.Text = finalresult.ToString();
        }

        private void button33_Click(object sender, EventArgs e)
        {

            int n = int.Parse(textBox1.Text);

            int factorial = CalculateFactorial(n);

            displaybox.Text = n + "!=";
            textBox1.Text = factorial.ToString();
        }
        private int CalculateFactorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * CalculateFactorial(n - 1);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            double re = double.Parse(textBox1.Text);
            displaybox.Text = "csc(" + re + ")" + "=";
            finalresult = 1 / Math.Sin(re);
            textBox1.Text = finalresult.ToString();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            this.Width = 437;
            textBox1.Width = 335;
        }

        private void calculatorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" 1. Habtamu Alelgn \n 2. Marshete \n 3. Baweke mekonnen \n \n 3rd Year software enginerring students! ");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calculator Guide:\n 1. Enter numbers using the numeric buttons.\n 2. Use '+' for addition, '-' for subtraction, '*' for multiplication, and '/' for division.\n 3. Click '=' to compute the result.\n 4. Use parentheses to control the order of operations.\n 5. Click 'C' to clear the last input, 'AC' to clear all.\n 6. Error messages will be shown for invalid expressions or division by zero.\n For further assistance, click the Help button or contact our support team.");
        }

        private void standardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Width = 437;
            textBox1.Width = 335;

        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 979;
            textBox1.Width = 544;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            double re = double.Parse(textBox1.Text);
            displaybox.Text = "Ceil";
            finalresult = Math.Ceiling(re);
            textBox1.Text = finalresult.ToString();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            double re = double.Parse(textBox1.Text);
            displaybox.Text = "Floor";
            finalresult = Math.Floor(re);
            textBox1.Text = finalresult.ToString();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            finalresult = 2.7182818284590452353602874713527;
            textBox1.Text = finalresult.ToString();
        }

        private void button40_Click(object sender, EventArgs e)
        {

            double re = double.Parse(textBox1.Text);
            displaybox.Text = "Cot(" + re + ")" + "=";
            finalresult = 1 / Math.Tan(re);
            textBox1.Text = finalresult.ToString();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            double re = double.Parse(textBox1.Text);
            displaybox.Text = "Cub of " + re + "=";
            finalresult = Math.Pow(re, 3);
            textBox1.Text = finalresult.ToString();

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}