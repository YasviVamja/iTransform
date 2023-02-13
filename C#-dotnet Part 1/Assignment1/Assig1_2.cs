using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Assig1_2
    {
        public static void MainExecution()
        {
            double[] marks = new double[5];
            double highestMarks = 0;

            Console.WriteLine("Enter the average marks of 5 students: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Student {0}: ", i + 1);
                marks[i] = Convert.ToDouble(Console.ReadLine());

                if (marks[i] > highestMarks)
                {
                    highestMarks = marks[i];
                }
            }

            Console.WriteLine("The highest marks obtained is: {0}", highestMarks);
        }
    }
}
