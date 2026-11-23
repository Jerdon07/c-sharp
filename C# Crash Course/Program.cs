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
            Car car = new Car("Toyota", "Raize", 2022, 5);

            car.DisplayInfo();
        }
    }

    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        protected int Year { get; set; }

        public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;

        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"{Brand} {Model} {Year}");
        }
    }

    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string brand, string model, int year, int doors) : base(brand, model, year)
        {
            NumberOfDoors = doors;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Number of doors: {NumberOfDoors}");
        }
    }
}
