using System;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            string inputNumberOne = Console.ReadLine();
            Console.WriteLine("Please enter another number!");
            string inputNumberTwo = Console.ReadLine();
            Console.WriteLine("Please enter an operator (+, -, /, *)!");
            string inputOperator = Console.ReadLine();
            double numOne;
            double numTwo;
            char userOperator;
            double sum;
            bool isParsedOne = double.TryParse(inputNumberOne, out numOne);
            bool isParsedTwo = double.TryParse(inputNumberTwo, out numTwo);
            bool isParsedOperator = char.TryParse(inputOperator, out userOperator);

            switch (userOperator)
            {
                case '+':
                    sum = numOne + numTwo;
                    Console.WriteLine($"The result is {sum}!");
                    break;
                case '-':
                    sum = numOne - numTwo;
                    Console.WriteLine($"The result is {sum}!");
                    break;
                case '/':
                    sum = numOne / numTwo;
                    Console.WriteLine($"The result is {sum}!");
                    break;
                case '*':
                    sum = numOne * numTwo;
                    Console.WriteLine($"The result is {sum}!");
                    break;
                default:
                    Console.WriteLine("Please enter valid numbers and a valid operator!");
                    break;
            }







            Console.ReadLine();
        }
    }
}
