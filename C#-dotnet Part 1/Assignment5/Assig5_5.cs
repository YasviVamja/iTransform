using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Assig5_5
    {
        public static void MainExecution()
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            Employee emp3 = new Employee();
            emp1.EmployeeID = 101;
            emp2.EmployeeID = 102;
            emp3.EmployeeID = 103;
            emp1.Name = "Employee 1";
            emp2.Name = "Employee 2";
            emp3.Name = "Employee 3";

            LinkedList<Employee> empList = new LinkedList<Employee>();
            Console.WriteLine("5)Search Employee object in Linkedlist by name of employee...");
            empList.AddLast(emp2);
            empList.AddLast(emp3);
            empList.AddFirst(emp1);
            // var result = list.Where(emp => emp.empName == "TheName");
            //var result = list.Where(emp => emp.empName == "TheName");
            Console.Write("Enter a name for search: ");
            string n = Console.ReadLine();
            var result = empList.FirstOrDefault(emp=>emp.Name==n);
            if (result == null)
            {
                Console.WriteLine("No Employee with this Name....");

            }
            else
            {
                Console.WriteLine("Emp with {0} as Name:", n);
                Console.WriteLine(result.ToString());
            }
        }
    }
}
