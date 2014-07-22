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
        private Account anAccount;
        public BankAccountAppUI()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
           anAccount = new Account(accountNoTextBox.Text, nameTextBox.Text);
            accLabel.Text = "Account Name: " + anAccount.Name + ". - Account No: " + anAccount.AccountNo;
        }

        

        private void depositButton_Click(object sender, EventArgs e)
        {
            string msg = anAccount.Deposit(Convert.ToDouble(amountTextBox.Text));
            MessageBox.Show(msg);

        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Baalnce: " + anAccount.Balance.ToString());
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            string msg = anAccount.WithDraw(Convert.ToDouble(amountTextBox.Text));
            MessageBox.Show("Balance: " + msg);
        }
    }
}
