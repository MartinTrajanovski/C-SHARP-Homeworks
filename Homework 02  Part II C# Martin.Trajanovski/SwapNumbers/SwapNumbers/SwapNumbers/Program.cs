using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            string inputNumberOne = Console.ReadLine();
            Console.WriteLine("Please enter another number!");
            string inputNumberTwo = Console.ReadLine();
            double numOne;
            double numTwo;
            
            bool isParsedOne = double.TryParse(inputNumberOne, out numOne);
            bool isParsedTwo = double.TryParse(inputNumberTwo, out numTwo);
            Console.WriteLine($"Before swapping, the first number is {numOne}, and the second number is {numTwo}!");
            double tempVariable = numOne;
            numOne = numTwo;
            numTwo = tempVariable;
            Console.WriteLine($"After swapping, the first number is {numOne}, and the second number is {numTwo}!");
            Console.ReadLine();
        }
    }
}
