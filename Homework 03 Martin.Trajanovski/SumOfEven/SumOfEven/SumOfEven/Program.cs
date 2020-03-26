using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = new int[6];
            int sum = 0;
            int counter = 0;
            Console.WriteLine("Please enter 5 numbers:");
            while (counter < arrayOfNumbers.Length)
            {
                if (int.TryParse(Console.ReadLine(), out arrayOfNumbers[counter]))
                {
                    counter++;
                } else
                {
                    Console.WriteLine("Please enter a number!");
                }
            }

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] % 2 == 0)
                {
                    sum += arrayOfNumbers[i];
                }
            }
            Console.WriteLine($"The sum of all even numbers in the array equals to {sum}!");
            Console.ReadLine();
        }
    }
}
