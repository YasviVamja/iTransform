using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Assig2_2
    {
        public static void MainExextution()
        {
            Console.WriteLine("Employee Management System");
            Console.WriteLine("=========================");

            try
            {
                Console.Write("Enter EmpNo: ");
                int empNo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter EmpName: ");
                string empName = Console.ReadLine();

                Console.Write("Enter Salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());

                Employee emp = new Employee(empNo, empName, salary);
                emp.CalculateSalary();

                Console.WriteLine("Gross Salary: " + emp.GetNetSalary());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
