using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment5
{
    class Employee
    {
        private int _empID;
        private string _name;
        public int EmployeeID
        {
            get { return _empID; }
            set { _empID = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public override string ToString() {
            return "Emp id = " + this.EmployeeID + " \t Emp Name = " + this.Name;
        }
    }
    internal class Assig5_2
    {
        public static void MainExecution()
        {
            Employee emp1= new Employee();
            Employee emp2= new Employee();
            Employee emp3= new Employee();
            emp1.EmployeeID = 101;
            emp2.EmployeeID = 102;
            emp3.EmployeeID = 103;
            emp1.Name = "Employee 1";
            emp2.Name = "Employee 2";
            emp3.Name = "Employee 3";

            Console.WriteLine("ArrayList Used to store Employee object contains:");
            ArrayList arrayListOfEmp=new ArrayList();
            arrayListOfEmp.Add(emp1);
            arrayListOfEmp.Add(emp2);
            arrayListOfEmp.Add(emp3);
            foreach(Employee emp in arrayListOfEmp)
            {
                Console.WriteLine(emp.ToString());
            }
        }
    }
}
