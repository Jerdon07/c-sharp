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
            Console.WriteLine("How many Languages do you know?:");
            int languages = int.Parse(Console.ReadLine());

            string[] lang = new string[languages];

            for (int i = 0; i < lang.Length; i++)
            {
                Console.Write($"Language {i + 1}: ");
                lang[i] = Console.ReadLine();
            }

            Console.WriteLine("Here're your Languages!:");
            foreach (string item in lang)
            {
                Console.WriteLine(item);
            }
        }
    }
}
