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
            Console.WriteLine("\nWelcome to my console calculator!");
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Write("Enter first number: ");
                double num1 = GetValidNumber();

                Console.Write("Enter operator (+, -, *, /): ");
                string operation = GetValidOperator();

                Console.Write("Enter second number: ");
                double num2 = GetValidNumber();

                double result = PerformCalculation(num1, num2, operation);
                Console.WriteLine(result);

                Console.Write("\nNew Calculation? (y/n): ");
                string continueResponse = Console.ReadLine()?.Trim().ToLower();
                keepRunning = continueResponse == "y";
            }

            Console.WriteLine("Thanks for using my calculator!");
        }

        static double GetValidNumber()
        {
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
        }

        static string GetValidOperator()
        {
            while (true)
            {
                string operation = Console.ReadLine()?.Trim();

                if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
                {
                    return operation;
                }
                else
                {
                    Console.WriteLine("Invalid operator.");
                }
            }
        }

        static double PerformCalculation(double num1, double num2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return num2 != 0 ? num1 / num2 : throw new DivideByZeroException("Can't divide by 0.");
                default:
                    throw new InvalidOperationException("Undexpected operator.");
            }
        }
    }
}
