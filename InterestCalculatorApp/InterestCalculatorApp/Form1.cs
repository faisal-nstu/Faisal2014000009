using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculatorApp
{
    public partial class InterestCalculatorUI : Form
    {
        public InterestCalculatorUI()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string bankName = bankNameComboBox.Text;
            int time = Convert.ToInt32(timeTextBox.Text);
            double totalInterest = 0;
            double interest = 0;
            double balance = Convert.ToDouble(balanceTextBox.Text);
            if (bankName == "BRAC")
            {
                for (int i = 0; i < time; i++)
                {
                    interest = balance * .06;
                    totalInterest = totalInterest + interest;
                }
                balance = balance + totalInterest;

                interestLabel.Text = "Total Interest = " + totalInterest.ToString();
                totalLabel.Text = "Total Balance = " + balance.ToString();

            }
            else if (bankName == "DBBL")
            {
                for (int i = 0; i < time; i++)
                {
                    interest = balance * .07;
                    
                    totalInterest = totalInterest + interest;
                }
                balance = balance + totalInterest;
                interestLabel.Text = "Total Interest = " + totalInterest.ToString();
                totalLabel.Text = "Total Balance = " + balance.ToString();

            }
            else if (bankName == "HSBC")
            {
                for (int i = 0; i < time; i++)
                {
                    interest = balance * .08;
                    totalInterest = totalInterest + interest;
                }
                balance = balance + totalInterest;

                interestLabel.Text = "Total Interest = " + totalInterest.ToString();
                totalLabel.Text = "Total Balance = " + balance.ToString();

            }
            else
                MessageBox.Show("invalid Selection");
        }
    }
}
