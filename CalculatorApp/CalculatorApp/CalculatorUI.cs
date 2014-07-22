using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorUI : Form
    {
        Calculator aCalculator = new Calculator();

        public CalculatorUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            GetValue();
            resulTextBox.Text = aCalculator.Add(aCalculator.firstNumber, aCalculator.secondNumber).ToString();
        }

        private void GetValue()
        {
            aCalculator.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            aCalculator.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            GetValue();
            resulTextBox.Text = aCalculator.Sub(aCalculator.firstNumber, aCalculator.secondNumber).ToString();
        }

        private void mulButton_Click(object sender, EventArgs e)
        {
            GetValue();
            resulTextBox.Text = aCalculator.Mul(aCalculator.firstNumber, aCalculator.secondNumber).ToString();
            
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            GetValue();
            resulTextBox.Text = aCalculator.Div(aCalculator.firstNumber, aCalculator.secondNumber).ToString();
        }
    }
}
