using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Assig5_1
    {
        public static void MainExecution()
        {
            Console.WriteLine("int Array Operation......\n");
            Array intArray = Array.CreateInstance(typeof(Int32),5);
            for (int i = intArray.GetUpperBound(0); i >= intArray.GetLowerBound(0); i--)   
            {
                intArray.SetValue((i * 10),i);
            }

            Console.WriteLine();
            Console.WriteLine("Array of interger is :");
            foreach (int ival in intArray)
            {
                Console.WriteLine(ival + " ");
            }

            Console.WriteLine();
            Array newIntArray= Array.CreateInstance(typeof(Int32),3);
            Array.Copy(intArray,newIntArray,3);
            Console.WriteLine("Array of interger copied is :");
            foreach (int ival in newIntArray)
            {
                Console.Write(ival+" ");
            }

            Console.WriteLine();
            Array.Sort(intArray);
            Console.WriteLine("Array of interger after sort is :");
            foreach (int ival in intArray)
            {
                Console.Write(ival + " ");
            }

            Console.WriteLine();
            Array.Reverse(intArray);
            Console.WriteLine("Array of interger after reversal is :");
            foreach (int ival in intArray)
            {
                Console.Write(ival + " ");
            }

            Console.WriteLine();
            Array.Clear(intArray, 1, 2);
            Console.WriteLine("Array of interger after using Clear(intArray, 1, 2) is :");
            foreach (int ival in intArray)
            {
                Console.Write(ival + " ");
            }
            Console.WriteLine(" ");

            Console.WriteLine("\nString Array Operation......\n");

            Array stringArray = Array.CreateInstance(typeof(String), 3);
            stringArray.SetValue("string 1", 0);
            stringArray.SetValue("String 2", 1);
            stringArray.SetValue("String 3", 2);

            Console.WriteLine("Array of string is :");
            foreach (string ival in stringArray)
            {
                Console.WriteLine(ival + " ");
            }

            Console.WriteLine();
            Array newStringArray = Array.CreateInstance(typeof(String), 3);
            Array.Copy(stringArray, newStringArray, 3);
            Console.WriteLine("Array of string copied is :");
            foreach (string ival in stringArray)
            {
                Console.Write(ival + " ");
            }

            Console.WriteLine();
            Array.Sort(stringArray);
            Console.WriteLine("Array of string after sort is :");
            foreach (string ival in stringArray)
            {
                Console.Write(ival + " ");
            }

            Console.WriteLine();
            Array.Reverse(stringArray);
            Console.WriteLine("Array of string after reversal is :");
            foreach (string ival in stringArray)
            {
                Console.Write(ival + " ");
            }

            Console.WriteLine();
            Array.Clear(stringArray,0,1);
            Console.WriteLine("Array of string after using Clear(stringArray,0,1) is :");
            foreach (string ival in stringArray)
            {
                Console.Write(ival + " ");
            }

        }
    }
}
