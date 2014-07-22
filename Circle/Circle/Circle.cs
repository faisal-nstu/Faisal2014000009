using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    
    class Circle
    {
        public const double PI = 3.1416;
        public double radius = 0;

        public double Diameter(double rad)
        {
            return rad*2;
        }

        public double Preimeter(double rad)
        {
            return 2*PI*rad;
        }

        public double Area(double rad)
        {
            return PI*rad*rad;
        }
    }
}
