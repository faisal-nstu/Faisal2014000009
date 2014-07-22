using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
       
        static void Main(string[] args)
        {
            double radius = 0;
            Circle aCircle = new Circle();


            Console.Write("Enter Radius: ");
            radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Diameter: " + aCircle.Diameter(radius));
            Console.WriteLine("Perimeter: " + aCircle
                .Preimeter(radius));
            Console.WriteLine("Area: " + aCircle.Area(radius));
            Console.ReadKey();

        }
    }
}
