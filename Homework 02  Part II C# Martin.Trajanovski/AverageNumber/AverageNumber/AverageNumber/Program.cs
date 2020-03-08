using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            string inputNumberOne = Console.ReadLine();
            Console.WriteLine("Please enter another number!");
            string inputNumberTwo = Console.ReadLine();
            Console.WriteLine("And another!");
            string inputNumberThree = Console.ReadLine();
            Console.WriteLine("And another!");
            string inputNumberFour = Console.ReadLine();

            double numOne;
            double numTwo;
            double numThree;
            double numFour;
            
            int divisor = 4;
            bool isParsedOne = double.TryParse(inputNumberOne, out numOne);
            bool isParsedTwo = double.TryParse(inputNumberTwo, out numTwo);
            bool isParsedThree = double.TryParse(inputNumberThree, out numThree);
            bool isParsedFour = double.TryParse(inputNumberFour, out numFour);
            double averageNumber = (numOne + numTwo + numThree + numFour) / divisor;
            int finalResult = Convert.ToInt32(Math.Floor(averageNumber));
            Console.WriteLine($"The result is {finalResult}");



            Console.ReadLine();
        }
    }
}
