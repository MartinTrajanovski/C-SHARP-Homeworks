using System;

namespace Profitable_Gambler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the probability of winning!");
            string inputNumberOne = Console.ReadLine();
            Console.WriteLine("Please enter the prize!");
            string inputNumberTwo = Console.ReadLine();
            Console.WriteLine("Please enter the cost of playing!");
            string inputNumberThree = Console.ReadLine();
            double probability;
            double prize;
            double cost;
            bool isParsedOne = double.TryParse(inputNumberOne, out probability);
            bool isParsedTwo = double.TryParse(inputNumberTwo, out prize);
            bool isParsedThree = double.TryParse(inputNumberThree, out cost);
            if (!isParsedOne || !isParsedTwo || !isParsedThree)
            {
                Console.WriteLine("Please enter valid numbers!");
            } else
            {
                if (probability * prize > cost)
                {
                    Console.WriteLine("You Won!");
                }
                else
                {
                    Console.WriteLine("You Lost!");
                }
            }

            Console.ReadLine();
        }
    }
}
