using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{

    internal class Assig1_5
    {
        static void CalculateCircleProperties(double radius, out double area, out double circumference)
        {
            area = Math.PI * radius * radius;
            circumference = 2 * Math.PI * radius;
        }
        public static void MainExecution()
        {
            Console.WriteLine("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = 0;
            double circumference = 0;

            CalculateCircleProperties(radius, out area, out circumference);

            Console.WriteLine("The area of the circle is: {0}", area);
            Console.WriteLine("The circumference of the circle is: {0}", circumference);
            Console.ReadLine();
        }
    }
}
