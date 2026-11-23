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
            Person person1 = new Person();

            Person person2 = new Person("Jerdon", 22);

            person1.Introduce();
            person2.Introduce();
        }
    }

    public class Person
    {
        public string Name;
        public int Age;

        public Person()
        {
            Console.WriteLine("Empty Constructor.");
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {Name} and I'm {Age} years old!");
        }

        public class BankAccount
        {
            private decimal __balance;

            public decimal Balance
            {
                get
                {
                    return __balance;
                }

                set
                {
                    if (value < 0)
                        __balance = 0;
                    else
                    {
                        __balance = value;
                    }
                }
            }

            public void Deposit(decimal amount)
            {
                Balance += amount;
            }

            public void Withdraw(decimal amount)
            {
                Balance -= amount;
            }
        }
    }
}
