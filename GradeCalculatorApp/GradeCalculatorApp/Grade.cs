using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCalculatorApp
{
    class Grade
    {
        public double physics;
        public double chemistry;
        public double math;
        public const int numOfSub=3;

        public double GetAverage(double phyMarks, double chemMarks, double mathMarks)
        {
            return (phyMarks + chemMarks + mathMarks)/numOfSub;
        }

        public string GradeLetter(double average)
        {
            if (average >= 80)
                return "A+";
            else if (average >= 70 && average < 80)
                return "B+";
            else if (average >= 60 && average < 70)
                return "C+";
            else if (average >= 50 && average < 60)
                return "D+";
            else if (average < 50)
               return "F";
            else
            {
                return "error";

            }
            
        }

    }
}
