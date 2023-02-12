using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    [Serializable]
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public decimal Salary { get; set; }
    }

    [Serializable]
    public class MarketingExecutive : Employee
    {
        public int Allowance { get; set; }
    }

    [Serializable]
    public class Manager : Employee
    {
        public int StockOptions { get; set; }
    }

    internal class Assig7_3and4
    {
        public static void MainExecution()
        {

            Console.WriteLine("Enter Manager Information");

            Console.WriteLine("Enter Manager ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Manager Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Manager Salary: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());

            Manager managerSE = new Manager { Id = id, Name = name, Salary = salary };

            // Serialize the Manager object


            SerializeBinary(managerSE);

            Manager managerDE = DeserializeBinary();

            Console.WriteLine("Manager Information");
            Console.WriteLine("ID: " + managerDE.Id);
            Console.WriteLine("Name: " + managerDE.Name);
            Console.WriteLine("Salary: " + managerDE.Salary);

        }
        public static void SerializeBinary(Manager managerSE)
        {
            Stream streamSE = File.Open("D:\\Text\\newfile.txt", FileMode.Create);
            BinaryFormatter formatterSE = new BinaryFormatter();
            formatterSE.Serialize(streamSE, managerSE);
            Console.WriteLine("Manager information saved successfully.");
            streamSE.Close();
        }

        public static Manager DeserializeBinary()
        {
            Stream streamDE = File.Open("D:\\Text\\newfile.txt", FileMode.Open);

            BinaryFormatter formatterDE = new BinaryFormatter();
            Manager managerDE = (Manager)formatterDE.Deserialize(streamDE);
            streamDE.Close();
            return managerDE;
        }
    }
}
