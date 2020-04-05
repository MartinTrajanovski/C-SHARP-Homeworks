using System;

namespace Demo
{
    public class Car
    {
        public string Make;
        public string Model;
        public string Color;
        public int NumberOfWheels;
        public int fuelCapacity;

        public void Start()
        {
            Console.WriteLine("Wroom!!");
        }
        public void Drive()
        {
            Console.WriteLine("Start driving!!");
        }
        public void Break()
        {
            Console.WriteLine("Breaaaak!");
        }
        public void GetCarSpecs()
        {
            Console.WriteLine($"The card model is {Model}\nThe car make is {Make}\nThe car color is {Color}\nThe car's fuel capacity is {fuelCapacity}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car ford = new Car();
            ford.Make = "Ford";
            ford.Model = "Mustang";
            ford.NumberOfWheels = 4;
            ford.fuelCapacity = 50;
            ford.Color = "Red";
            ford.Start();
            ford.Drive();
            ford.Break();
            ford.GetCarSpecs();


            Console.ReadLine();
        }
    }
}
