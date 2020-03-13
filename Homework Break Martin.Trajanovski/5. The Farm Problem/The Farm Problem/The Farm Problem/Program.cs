using System;

namespace The_Farm_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many chickens do you have?");
            string inputNumberOne = Console.ReadLine();
            Console.WriteLine("How many cows do you have?");
            string inputNumberTwo = Console.ReadLine();
            Console.WriteLine("How many pigs do you have?");
            string inputNumberThree = Console.ReadLine();
            double chickens;
            double cows;
            double pigs;
            double numberOfLegs;
            bool isParsedOne = double.TryParse(inputNumberOne, out chickens);
            bool isParsedTwo = double.TryParse(inputNumberTwo, out cows);
            bool isParsedThree = double.TryParse(inputNumberThree, out pigs);
            if (!isParsedOne || !isParsedTwo || !isParsedThree)
            {
                Console.WriteLine("Please enter valid numbers!");
            } else
            {
                numberOfLegs = chickens * 2 + cows * 4 + pigs * 4;
                Console.WriteLine($"You have a total of {numberOfLegs} legs running around your farm!");
            }





            Console.ReadLine();
        }
    }
}
