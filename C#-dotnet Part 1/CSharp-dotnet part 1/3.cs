using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_dotnet_part_1
{
    internal class SumofArray
    {
        public static void FindSum(params int[] arrayofint)
        {
            int sum = 0;
            foreach (int i in arrayofint)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum of array of int :{0}", sum);
        }
    }
}
