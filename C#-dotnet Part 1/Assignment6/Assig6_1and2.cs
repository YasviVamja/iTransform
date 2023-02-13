using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3;

namespace Assignment6
{
    
    class Assig6_1and2
    {
        public delegate void Print();
        public static void MainExecution()
        {

            Console.WriteLine("Enter the Manager information:");

            Console.WriteLine("Enter Employee Number:");
            int empNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name:");
            string empName = Console.ReadLine();

            Console.WriteLine("Enter Salary:");
            double salary = double.Parse(Console.ReadLine());

            Manager manager = new Manager(empNo, empName, salary);
            manager.CalculateSalary();
            Console.WriteLine("Manager Information:");

            Console.WriteLine();
            Console.WriteLine("Using unicast Delegate for Print Function");
            Print Show = new Print(manager.Print);
            Show();



            Console.WriteLine("\n\nEnter the Marketing Executive information:");

            Console.WriteLine("Enter Employee Number:");
            int empNo1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name:");
            string empName1 = Console.ReadLine();

            Console.WriteLine("Enter Salary:");
            double salary1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Kilometer Travel:");
            int kmTravel = int.Parse(Console.ReadLine());
            MarketingExecutive me = new MarketingExecutive(empNo1, empName1, salary1, kmTravel);
            me.CalculateSalary();
            Show += me.Print;
            Console.WriteLine("\nUsing Multicast Delegate for Print Function");
            Show();

        }

    }
}
