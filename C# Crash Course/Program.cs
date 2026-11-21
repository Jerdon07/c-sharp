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
            bool session = true;
            int balance = 1000;

            Console.WriteLine("Welcome to my ATM!");

            do
            {
                Console.WriteLine();
                Console.WriteLine("Please choose your transaction (deposit/withdraw/balance/exit):");
                string option = Console.ReadLine();

                // Deposit
                if (option == "deposit")
                {
                    Console.Write("Enter amount to deposit: ");
                    int amount = int.Parse(Console.ReadLine());

                    if (balance < amount) {
                        Console.WriteLine("Invalid amount!");
                        break;
                    } else {
                        balance += amount;
                        Console.WriteLine($"New Balance: {balance}");
                    }
                }

                // Withdraw
                if (option == "withdraw")
                {
                    Console.Write("Enter amount to withdraw: ");
                    int amount = int.Parse(Console.ReadLine());

                    if (balance < amount)
                    {
                        Console.WriteLine("Invalid amount!");
                        break;
                    }
                    else
                    {
                        balance -= amount;
                        Console.WriteLine($"New Balance: {balance}");
                    }
                }

                // Check Balance
                if (option == "balance")
                {
                    Console.WriteLine("Here's your balance:");
                    Console.WriteLine(balance);
                }

                // Exit
                if (option == "exit")
                {
                    Console.WriteLine("THank you for using my ATM!");
                    session = false;
                }
            } while (session);
        }
    }
}
