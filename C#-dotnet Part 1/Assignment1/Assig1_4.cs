using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Assig1_4
    {
        static void Swap(ref int first, ref int second)
        {
            first = first + second;
            second = first- second;
            first = first - second;
        }
        public static void MainExecution()
        {
            Console.WriteLine("Enter the first integer: ");
            int firstInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second integer: ");
            int secondInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The first integer before swap: {0}", firstInt);
            Console.WriteLine("The second integer before swap: {0}", secondInt);
            Swap(ref firstInt, ref secondInt);

            Console.WriteLine("The first integer after swap: {0}", firstInt);
            Console.WriteLine("The second integer after swap: {0}", secondInt);
            
        }
    }
}
