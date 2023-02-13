using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Assignment5
{
    internal class Assig5_3
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
            Console.WriteLine("a)Adding Employee object in Linkedlist...");
            empList.AddLast(emp2);
            empList.AddLast(emp3);
            empList.AddFirst(emp1);
            Console.WriteLine("Added Employee object in Linkedlist...");
            Console.WriteLine("b)Displaying Employee object in Linkedlist...");
            foreach (Employee emp in empList)
            {
                Console.WriteLine("Emp id = {0} \t Emp Name = {1}", emp.EmployeeID, emp.Name);
            }
            Console.WriteLine("c)Total number of employees in the list:{0}", empList.Count);
        }
    }
}
