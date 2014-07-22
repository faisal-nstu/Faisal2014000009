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
            //GetValue();
            //MessageBox.Show("Account Created.\nName: " + anAccount.name + "\nAccount No.: " + anAccount.accountNo);
        }

        

        private void depositButton_Click(object sender, EventArgs e)
        {
            string msg = anAccount.Deposit(Convert.ToDouble(amountTextBox.Text));
            MessageBox.Show(msg);

        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            //string msg = anAccount.Report();
            //MessageBox.Show("Balance" + msg);
            MessageBox.Show("Baalnce: " + anAccount.Balance.ToString());
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            string msg = anAccount.WithDraw(Convert.ToDouble(amountTextBox.Text));
            MessageBox.Show("Balance: " + msg);
        }
    }
}
