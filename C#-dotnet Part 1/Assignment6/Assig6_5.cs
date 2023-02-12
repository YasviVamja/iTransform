using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class HDFCBank: Account
    {
        public delegate void UnderBalanceEventHandler(double currentBalance);
        public delegate void BalanceZeroEventHandler();
        public event UnderBalanceEventHandler UnderBalance;
        public event BalanceZeroEventHandler BalanceZero;
        public void Withdraw(double amount)
        {
            if (Balance  < 1000 && Balance>0)
            {
                Console.WriteLine("Underbalance after Withdrawal");
                UnderBalance(Balance);
            }
            else if (Balance == 0)
            {
                Console.WriteLine("Balance is zero");
                BalanceZero();
            }
            else
            {
                Balance -= amount;
            }
            //if (Balance < 1000)
            //{
            //    UnderBalance(Balance);
            //}
        }
        public static void HandleUnderBalanceEvent(double currentBalance)
        {
            if (currentBalance < 1000)
            {
                Console.WriteLine("Transaction cannot be continued below specified limit of Rs. -1000. Current balance: " + currentBalance);
            }
        }

        public static void HandleBalanceZeroEvent()
        {
            Console.WriteLine("Transaction cannot be continued as balance is zero in Account.");
        }
    }
    internal class Assig6_5
    {
        public static void MainExecution()
        {
            HDFCBank account = new HDFCBank
            {
                AccountNumber = 12345,
                CustomerName = "Name",
                Balance = 10000
            };

            account.UnderBalance += HDFCBank.HandleUnderBalanceEvent;
            account.BalanceZero += HDFCBank.HandleBalanceZeroEvent;

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
    }
}
