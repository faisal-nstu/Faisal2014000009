using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountApp
{
    public partial class BankAccountAppUI : Form
    {
        Account anAccount = new Account();
        public BankAccountAppUI()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            anAccount.accountNo = accountNoTextBox.Text;
            anAccount.name = nameTextBox.Text;
            anAccount.balance = 0;
            nameTextBox.Text = "";
            accountNoTextBox.Text = "";
            MessageBox.Show("Account Created.\nName: " + anAccount.name + "\nAccount No.: " + anAccount.accountNo);
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (amountTextBox.Text == String.Empty)
            {
                MessageBox.Show("Please enter an amount to deposit.");
            }
            else
            {
                anAccount.balance = anAccount.balance + Convert.ToDouble(amountTextBox.Text);
                amountTextBox.Text = "";
            }
            
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: " + anAccount.name + "\nAccount No.: " + anAccount.accountNo + "\nBalance: " +
                            anAccount.balance);
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (amountTextBox.Text == String.Empty)
                MessageBox.Show("Please enter amount");
            else if(Convert.ToDouble(amountTextBox.Text) > anAccount.balance)
            {
                MessageBox.Show("Not enough Balance");
                amountTextBox.Text = "";
            }
             
            else
            {
                anAccount.balance = anAccount.balance - Convert.ToDouble(amountTextBox.Text);
                MessageBox.Show(amountTextBox.Text + " Tk. withdrawn from Account: " + anAccount.accountNo + "\nNew Balance: " + anAccount.balance);
                amountTextBox.Text = "";
            }
        }
    }
}
