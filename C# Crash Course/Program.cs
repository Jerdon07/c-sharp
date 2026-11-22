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
            bool checkStudent(char is_student = 'n') {
                return char.ToLower(is_student) == 'y';
            }

            string getUniversity()
            {
                Console.Write("Enter university: ");
                return Console.ReadLine() ?? "";
            }

            void userInformation(string user_name, int user_age, bool is_student, string user_university = "")
            {
                string birth_year =  (2026 - user_age).ToString();

                Console.WriteLine();
                Console.WriteLine($"Hello {user_name}!");
                Console.WriteLine($"Your are cuurently {user_age}, born in year {birth_year}!");

                if (is_student)
                {
                    Console.WriteLine($"You're currently enrolled in {user_university}");
                }
                else
                {
                    Console.WriteLine("Congrats on your first step of your career! Good luck on your way of achieving your dream! Gambare gambare!");
                }
            }

            Console.Write("Enter Name: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Are you a college student? (y/n): ");
            bool student = checkStudent(char.Parse(Console.ReadLine() ?? "n"));

            string university = student ? getUniversity() : "";

            userInformation(
                user_name: name,
                user_age: age,
                is_student: student,
                user_university: university
            );
        }
    }
}
