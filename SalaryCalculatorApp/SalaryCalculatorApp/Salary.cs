using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApp
{
    class Salary
    {
        public string name;
        public double basicAmount;
        public double rent;
        public double medicalAllowance;

        public double ShowSalary(double basic, double rent, double allowance)
        {
            return basic + (basic*rent)/100 + (basic*allowance)/100;
        }


    }
}
