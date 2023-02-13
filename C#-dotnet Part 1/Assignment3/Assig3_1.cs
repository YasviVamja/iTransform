using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public interface IPrintable
    {
        void Print();
    }
    public class Employee : IPrintable
    {
        protected int empNo;
        protected string empName;
        protected double salary;
        protected double hra;
        protected double ta;
        protected double da;
        protected double pf;
        protected double tds;
        protected double netSalary;
        protected double grossSalary;

        public Employee(int empNo, string empName, double salary)
        {
            this.empNo = empNo;
            this.empName = empName;
            this.salary = salary;
            if (salary < 5000)
            {
                hra = salary * 0.1;
                ta = salary * 0.05;
                da = salary * 0.15;
            }
            else if (salary < 10000)
            {
                hra = salary * 0.15;
                ta = salary * 0.1;
                da = salary * 0.2;
            }
            else if (salary < 15000)
            {
                hra = salary * 0.2;
                ta = salary * 0.15;
                da = salary * 0.25;
            }
            else if (salary < 20000)
            {
                hra = salary * 0.25;
                ta = salary * 0.2;
                da = salary * 0.3;
            }
            else
            {
                hra = salary * 0.3;
                ta = salary * 0.25;
                da = salary * 0.35;
            }

        }

        public virtual void CalculateSalary()
        {
            grossSalary = salary + hra + ta + da;
            pf = grossSalary * 0.1;
            tds = grossSalary * 0.18;
            netSalary = grossSalary - (pf + tds);
        }

        public double GetNetSalary()
        {
            return netSalary;
        }
        public void Print()
        {
            Console.WriteLine("EmpNo: " + empNo);
            Console.WriteLine("EmpName: " + empName);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("HRA: " + hra);
            Console.WriteLine("TA: " + ta);
            Console.WriteLine("DA: " + da);
            Console.WriteLine("PF: " + pf);
            Console.WriteLine("TDS: " + tds);
            Console.WriteLine("NetSalary: " + netSalary);
        }
    }
    public class Manager : Employee
    {
        private double petrolAllowance;
        private double foodAllowance;
        private double otherAllowance;

        public Manager(int empNo, string empName, double salary) : base(empNo, empName, salary) { }

        public override void CalculateSalary()
        {
            base.CalculateSalary();

            petrolAllowance = salary * 0.08;
            foodAllowance = salary * 0.13;
            otherAllowance = salary * 0.03;

            grossSalary = salary + hra + ta + da + petrolAllowance + foodAllowance + otherAllowance;
            netSalary = grossSalary - pf - tds -(petrolAllowance + foodAllowance + otherAllowance);
        }
    }
    public class MarketingExecutive : Employee
    {
        private int kilometersTraveled;
        private double tourAllowance;
        private double telephoneAllowance = 1000;

        public MarketingExecutive(int empNo, string empName, double salary, int kilometerTravel)
           : base(empNo, empName, salary)
        {
            this.kilometersTraveled = kilometerTravel;
            this.tourAllowance = kilometerTravel * 5;
        }

        public override void CalculateSalary()
        {
            base.CalculateSalary();
            grossSalary = salary + tourAllowance + telephoneAllowance;
            pf = salary * 0.1;
            tds = grossSalary * 0.18;
            netSalary = salary - (pf+ tds);
        }
    }
    internal class Assig3_1
    {
        public static void MainExecution()
        {
            try
            {
                Console.WriteLine("Enter the employee information:");

                Console.WriteLine("Enter Employee Number:");
                int empNo = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Employee Name:");
                string empName = Console.ReadLine();

                Console.WriteLine("Enter Salary:");
                double salary = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Employee Type (M for Manager, ME for Marketing Executive):");
                string employeeType = Console.ReadLine().ToUpper();

                switch (employeeType)
                {
                    case "M":
                        Manager manager = new Manager(empNo, empName, salary);
                        manager.CalculateSalary();
                        Console.WriteLine("Manager Information:");
                        manager.Print();
                        break;
                    case "ME":
                        Console.WriteLine("Enter Kilometer Travel:");
                        int kmTravel = int.Parse(Console.ReadLine());
                        MarketingExecutive me = new MarketingExecutive(empNo, empName, salary, kmTravel);
                        me.CalculateSalary();
                        me.Print();
                        break;
                    default:
                        Employee employee = new Employee(empNo, empName, salary);
                        employee.CalculateSalary();
                        Console.WriteLine("Employee Information:");
                        employee.Print();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }
    }
}
