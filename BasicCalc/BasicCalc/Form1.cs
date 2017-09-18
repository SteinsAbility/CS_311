using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalc
{
    public partial class Form1 : Form
    {

        String num1 = "", num2 = "", expression = "";
        int x = 0, y = 0, result = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           expression += "1";
           label1.Text = expression;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            expression += "2";
            label1.Text = expression;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            expression += "3";
            label1.Text = expression;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            expression += "4";
            label1.Text = expression;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            expression += "5";
            label1.Text = expression;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            expression += "6";
            label1.Text = expression;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            expression += "7";
            label1.Text = expression;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            expression += "8";
            label1.Text = expression;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            expression += "9";
            label1.Text = expression;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            expression += "0";
            label1.Text = expression;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            result = Calculate();
            expression = result.ToString();
            label1.Text = expression;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            expression += " + ";
            label1.Text = expression;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            expression += " - ";
            label1.Text = expression;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            expression += " * ";
            label1.Text = expression;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            expression += " / ";
            label1.Text = expression;
        }

        private int Calculate()
        {
            int result = 0;
            num1 = expression.Substring(0, expression.IndexOf(" "));
            x = int.Parse(num1);
            num2 = expression.Substring(expression.LastIndexOf(" "));
            y = int.Parse(num2);
            if (expression.Contains(" + "))
                result = x + y;
            else if (expression.Contains(" - "))
                result = x - y;
            else if (expression.Contains(" * "))
                result = x * y;
            else if (expression.Contains(" / "))
                result = x / y;
            return result;
        }

    }
}
