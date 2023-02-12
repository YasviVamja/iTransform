using System;
using System.IO;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment7
{
    class Assig7_2
    {
        public static void MainExecution()
        {
            int choice;
            do
            {
                Console.WriteLine("1. Add customer information");
                Console.WriteLine("2. View customer information\n3. Exit\nEnter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddCustomerInformation();
                        break;
                    case 2:
                        ViewCustomerInformation();
                        break;
                    default:
                        break;
                }
            } while (choice != 3);
        }

        static void AddCustomerInformation()
        {
            Console.WriteLine("Enter customer name: ");
            string customerName = Console.ReadLine();

            Console.WriteLine("Enter account number: ");
            int accountNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter balance: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            Account customerAccount = new Account(customerName, accountNumber, balance);

            StreamWriter streamWriter = new StreamWriter("D:\\Text\\new.txt", true);
            streamWriter.WriteLine(customerName + "," + accountNumber + "," + balance);
            
            Console.WriteLine("Customer information added successfully.");
            streamWriter.Close();
        }

        static void ViewCustomerInformation()
        {
            StreamReader streamReader = new StreamReader("D:\\Text\\new.txt");
            
            Console.WriteLine("Customer Name\tAccount Number\tBalance");
            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                string[] customerInformation = line.Split(',');
                Console.WriteLine(customerInformation[0] + "\t\t" + customerInformation[1] + "\t\t" + customerInformation[2]);
            }
            streamReader.Close();
        }
    }

    class Account
    {
        public string CustomerName { get; set; }
        public int AccountNumber { get; set; }
        public double Balance { get; set; }

        public Account(string customerName, int accountNumber, double balance)
        {
            CustomerName = customerName;
            AccountNumber = accountNumber;
            Balance = balance;
        }
    }
}
