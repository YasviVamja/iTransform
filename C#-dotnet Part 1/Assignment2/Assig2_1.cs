using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment2
{
    public class Employee
    {
        private int EmpNo;
        private string EmpName;
        private double Salary;
        private double HRA;
        private double TA;
        private double DA;
        private double PF;
        private double TDS;
        private double NetSalary;
        private double GrossSalary;

        public Employee(int empNo, string empName, double salary)
        {
            EmpNo = empNo;
            EmpName = empName;
            Salary = salary;
            if (Salary < 5000)
            {
                HRA = Salary * 0.1;
                TA = Salary * 0.05;
                DA = Salary * 0.15;
            }
            else if (Salary < 10000)
            {
                HRA = Salary * 0.15;
                TA = Salary * 0.10;
                DA = Salary * 0.20;
            }
            else if (Salary < 15000)
            {
                HRA = Salary * 0.2;
                TA = Salary * 0.15;
                DA = Salary * 0.25;
            }
            else if (Salary < 20000)
            {
                HRA = Salary * 0.25;
                TA = Salary * 0.20;
                DA = Salary * 0.30;
            }
            else
            {
                HRA = Salary * 0.3;
                TA = Salary * 0.25;
                DA = Salary * 0.35;
            }

            GrossSalary = Salary + HRA + TA + DA;
        }

        public void CalculateSalary()
        {
            
            PF = GrossSalary * 0.1;
            TDS = GrossSalary * 0.18;
            NetSalary = GrossSalary - (PF + TDS);
        }

        public double GetNetSalary()
        {
            return NetSalary;
        }

        public void PrintSalaryDetails()
        {
            Console.WriteLine("EmpNo: " + EmpNo);
            Console.WriteLine("EmpName: " + EmpName);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("HRA: " + HRA);
            Console.WriteLine("TA: " + TA);
            Console.WriteLine("DA: " + DA);
            Console.WriteLine("PF: " + PF);
            Console.WriteLine("TDS: " + TDS);
            Console.WriteLine("NetSalary: " + NetSalary);
        }
    }

    internal class Assig2_1
    {
        public static void MainExextution()
        {
            Employee e = new Employee(1, "Name", 10000);
            e.CalculateSalary();
            e.PrintSalaryDetails();
        }
    }
}

