using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAndAccountApp
{
    class Account
    {
        public string AccountNo { get; private set; }
        public string OpeningDate { get; private set; }
        public double Balance { get; private set; }


        public Account(string accountNo, string openingDate):this()
        {
            AccountNo = accountNo;
            OpeningDate = openingDate;
        }

        public Account()
        {
            Balance = 0;
        }

        public string Deposit(double amount)
        {
            Balance += amount;
            return "Deposited";
        }


        public string Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                return "Withdrawn";
            }
            else
            {
                return "No sufficient balance to withdraw";
            }

        }




    }
}
