using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Calculator
    {
        public double firstNumber;
        public double secondNumber;

        public double Add(double fstNum, double sndNum)
        {
            return fstNum + sndNum;

        }


        public double Sub(double fstNum, double sndNum)
        {
            return fstNum - sndNum;
        }

        public double Mul(double fstNum, double sndNum)
        {
            return fstNum * sndNum;
        }

        public double Div(double fstNum, double sndNum)
        {
            return fstNum / sndNum;
        }

    }
}
