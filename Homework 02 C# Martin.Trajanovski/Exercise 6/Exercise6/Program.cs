using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number!");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another number!");
            double number2 = Convert.ToDouble(Console.ReadLine());
            double largerOfTheTwo;
            if(number1 > number2)
            {
                largerOfTheTwo = number1;
                if (largerOfTheTwo % 2 == 0)
                {
                    Console.WriteLine($"The number {largerOfTheTwo} is the larger number and it is even!");
                } else
                {
                    Console.WriteLine($"The number {largerOfTheTwo} is the larger number and it is odd!");
                }
            } else if (number2 > number1)
            {
                largerOfTheTwo = number2;
                if (largerOfTheTwo % 2 == 0)
                {
                    Console.WriteLine($"The number {largerOfTheTwo} is the larger number and it is even!");
                } else
                {
                    Console.WriteLine($"The number {largerOfTheTwo} is the larger number and it is odd!");
                }
            } else
            {
                Console.WriteLine($"The numbers are even!");
            }
            Console.ReadLine();
        }
    }
}
