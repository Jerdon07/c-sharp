using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Crash_Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            account.Deposit(100);
            account.Withdraw(10);
            account.Withdraw(20);

            Console.WriteLine(account.Balance);
        }

        public class BankAccount
        {
            private decimal balance;

            public decimal Balance
            {
                get { return balance; }
                private set { balance = value; }
            }

            public void Deposit(decimal amount)
            {
                if (amount > 0)
                {
                    balance += amount;
                    Console.WriteLine($"Deposited ${amount}. New balance: ${balance}");
                }
            }

            public void Withdraw(decimal amount)
            {
                if (amount > balance || amount < 0)
                {
                    Console.WriteLine("Insufficient funds or invalid amount");
                }
                else
                {
                    balance -= amount;
                    Console.WriteLine($"Withdrawn ${amount}. New balance: ${balance}");
                }
            }
        }
    }
}
