using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Assig5_4
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

            Stack<Employee> empStack=new Stack<Employee>();
            Console.WriteLine("a)Pushing Employee object in Stack....");
            empStack.Push(emp1);
            empStack.Push(emp2);
            empStack.Push(emp3);
            foreach(Employee emp in empStack )
            {
                Console.WriteLine(emp.ToString()+"\t Count:"+empStack.Count);
            }

            Console.WriteLine("a)Poping Employee object in Stack....");
            while (empStack.Count > 0)
            {
                Employee e=empStack.Pop();
                Console.WriteLine(e.ToString() + "\t Count:" + empStack.Count);
            }
        }
        }
}
