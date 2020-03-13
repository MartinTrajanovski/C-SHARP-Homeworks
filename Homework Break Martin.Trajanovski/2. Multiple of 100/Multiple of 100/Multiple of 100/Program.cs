using System;

namespace Multiple_of_100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number!");
            string inputNumber = Console.ReadLine();
            double num;
            bool isParsed = double.TryParse(inputNumber, out num);
            if (isParsed)
            {
                if (num % 100 == 0)
                {
                    Console.WriteLine("You have entered a cool number!");
                } else
                {
                    Console.WriteLine("The number you've enterd is not cool at all!");
                }
            } else
            {
                Console.WriteLine("Can't you read? Enter a number, not anything else!");
            }




            Console.ReadLine();
        }
    }
}
