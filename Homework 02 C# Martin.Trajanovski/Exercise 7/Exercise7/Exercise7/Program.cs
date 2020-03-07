using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer from 1 - 3!");
            string inputNumber = Console.ReadLine();
            double num;
            bool isParsed = double.TryParse(inputNumber, out num);

            switch (num)
            {
                case 1:
                    Console.WriteLine("You won a new car!");
                    break;
                case 2:
                    Console.WriteLine("You won a new plane!");
                    break;
                case 3:
                    Console.WriteLine("You won a new bike!");
                    break;
                default:
                    Console.WriteLine("Please enter a valid number!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
