using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    class Account
    {
        private string name;
        private string accountNo;
        private double balance;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string AccountNo
        {
            get { return accountNo; }
            set { accountNo = value; }
        }

        public double Balance
        {
            get { return balance; }
            
        }

        public string Deposit(double amount)
        {
           
            balance = balance + amount;
            return "Deposited";
        }

        public string WithDraw(double amount)
        {
            
            if (amount > balance)
            {
                
                return "Not Possible";
            }

            else
            {
                balance = balance - amount;
                return balance.ToString();

            }
        }

        //public string Report()
        //{
        //    return balance.ToString();
        //}
    }
}
