using System;

namespace Future_prediction
{
    class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random();
            int luckyNumber = number.Next(1, 6);
            switch (luckyNumber)
            {
                case 1:
                    Console.WriteLine($"You won a jackpot worth 1.000.000EUR!");
                    break;
                case 2:
                    Console.WriteLine($"You will lose weight!");
                    break;
                case 3:
                    Console.WriteLine($"Your boyfriend will break up with you!");
                    break;
                case 4:
                    Console.WriteLine($"Your cousin will buy you a dog!");
                    break;
                case 5:
                    Console.WriteLine($"You will live to be a hundred!");
                    break;
                default:
                    Console.WriteLine("");
                    break;
            }




            Console.ReadLine();
        }
    }
}
