using Assignment6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class ICICIBank: Account
    {
        public delegate void UnderBalanceEventHandler(double currentBalance);
        public delegate void BalanceZeroEventHandler();
        public event UnderBalanceEventHandler UnderBalance;
        public event BalanceZeroEventHandler BalanceZero;
        public void Withdraw(double amount)
        {
            if (Balance-amount < 200 && Balance > 0)
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
        }
        public static void HandleUnderBalanceEvent(double currentBalance)
        {
            Console.WriteLine("Transaction cannot be continued as balance is insufficient in Account. Current balance: " + currentBalance);
        }

        public static void HandleBalanceZeroEvent()
        {
            Console.WriteLine("Transaction cannot be continued as balance is zero in Account.");
        }
    }
    public class Assig6_4
    {
        public static void MainExecution()
        {
            ICICIBank account = new ICICIBank
            {
                AccountNumber = 12345,
                CustomerName = "Name",
                Balance = 1000
            };
            account.UnderBalance += ICICIBank.HandleUnderBalanceEvent;
            account.BalanceZero += ICICIBank.HandleBalanceZeroEvent;

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

