using System;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the temperature in Celsius!");
            string inputTemp = Console.ReadLine();
            double temperature;
            double fahrenheit;
            double kelvin;
            bool isParsed = double.TryParse(inputTemp, out temperature);
            if (isParsed)
            {
                fahrenheit = (temperature * 9 / 5) + 32;
                kelvin = temperature + 273.15;
                Console.WriteLine($"{temperature} degrees Celsius equals to {fahrenheit}F and {kelvin}K!");
            }
            else
            {
                Console.WriteLine("Please enter a valid temperature!");
            }
            Console.ReadLine();
        }
    }
}
