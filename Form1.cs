using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double num1;
        string op;

        public Form1()
        {
            InitializeComponent();
        }


        private void Button(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }


 
        private void Form1_Click(object sender, EventArgs e)
        {
            op = ((Button)sender).Text;
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double num2 = Convert.ToDouble(textBox1.Text);

            switch (op)
            {
                case "+":
                    num1 = num1 + num2;
                    break;
                case "-":
                    num1 = num1 - num2;
                    break;
                case "/":
                    num1 = num1 / num2;
                    break;
                case "*":
                    num1 = num1 * num2;
                    break;
            }

            textBox1.Text = num1.ToString();
        }
    }
}
