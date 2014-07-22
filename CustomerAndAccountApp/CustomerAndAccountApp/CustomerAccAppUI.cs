using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerAndAccountApp
{
    
    public partial class CustomerAccAppUI : Form
    {
        private Customer customerObj = null;    
        public CustomerAccAppUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            customerObj = new Customer();
            Account anAccount = new Account(accountnoInputTextBox.Text,
            openingDateInputTextBox.Text);
            customerObj.CustomerName = customerNameInputTextBox.Text;
            customerObj.Email = emailInoputTextBox.Text;
            customerObj.AnAccount = anAccount;
            MessageBox.Show(customerObj.CustomerName + " has opened an account with " +
                            customerObj.AnAccount.AccountNo + " number");

        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            double amount;
            amount = Convert.ToDouble(amountInputTextBox.Text);
            if (customerObj.AnAccount.Deposit(amount)== "Deposited")
            {
                MessageBox.Show(amount + " Tk. has been deposited");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }

        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            double amount;
            amount = Convert.ToDouble(amountInputTextBox.Text);
            if (customerObj.AnAccount.Withdraw(amount) == "Withdrawn")
            {
                MessageBox.Show(amount + " Tk. has been withdrawn");
            }
            else
            {
                MessageBox.Show("Insufficient amount");
            }

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showCustomerNameTextBox.Text = customerObj.CustomerName;
            showEmailTextBox.Text = customerObj.Email;
            showAccountNoTextBox.Text = customerObj.AnAccount.AccountNo;
            showOpeningDateTextBox.Text = customerObj.AnAccount.OpeningDate;
            showBalanceTextBox.Text = customerObj.AnAccount.Balance.ToString();

        }
    }
}
