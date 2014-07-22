using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterestCalculator
{
    class AccountInfo
    {
        public double principalAmount ;
        public int timePeriod;
        public double rate;


        public double CalculateInterest()
        {
            double totalAmount = 0;
            double interest;

            

            interest = (principalAmount / 100) * rate * timePeriod;

            totalAmount = principalAmount + interest;
            return totalAmount;


        }
    }
}
