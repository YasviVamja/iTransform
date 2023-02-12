using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; set; }

        public delegate void UnderBalanceEventHandler(double currentBalance);
        public delegate void BalanceZeroEventHandler();
        public event UnderBalanceEventHandler UnderBalance;
        public event BalanceZeroEventHandler BalanceZero;

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public virtual void Withdraw(double amount)
        {
            Balance -= amount;
            if (Balance < 200)
            {
                Console.WriteLine("Underbalance");
                UnderBalance(Balance);
            }
            else if (Balance == 0)
            {
                Console.WriteLine("Balance is zero");
                BalanceZero();
            }
        }
    }

    public class Assig6_3
    {
        public static void MainExecution()
        {
            Account account = new Account
            {
                AccountNumber = 12345,
                CustomerName = "Name",
                Balance = 1000
            };

            account.UnderBalance += UnderBalanceEvent;
            account.BalanceZero += BalanceZeroEvent;

            Console.WriteLine("Account Details:");
            Console.WriteLine("Account Number: " + account.AccountNumber);
            Console.WriteLine("Customer Name: " + account.CustomerName);
            Console.WriteLine("Balance: " + account.Balance);
            int n = 1;
            while (n != 3)
            {
                Console.WriteLine("\n1)Withdraw\n2)Deposit:\n3)exit\nEnter your choise:");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        {
                            Console.WriteLine("\nEnter amount to withdraw:");
                            double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                            account.Withdraw(withdrawAmount);
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("\nEnter amount to deposit:");
                            double depositAmount = Convert.ToDouble(Console.ReadLine());
                            account.Deposit(depositAmount);
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }

                Console.WriteLine("\nFinal Balance: " + account.Balance);
            }
        }

        static void UnderBalanceEvent(double currentBalance)
        {
            Console.WriteLine("Your account balance is less than 200. Current balance: " + currentBalance);
        }

        static void BalanceZeroEvent()
        {
            Console.WriteLine("Your account balance is 0.");
        }
    } }