using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Assig1_3
    {
        public static void FindSum(params int[] arrayofint)
        {
            int sum = 0;
            Console.WriteLine("Array is:");
            foreach (int i in arrayofint)
            {
                Console.Write(i+" ");
                sum = sum + i;
            }
            Console.WriteLine("\nSum of array of int :{0}", sum);
        }
        public static void MainExecution()
        {
            FindSum(1, 2, 3, 4, 5);
        }
    }
}
