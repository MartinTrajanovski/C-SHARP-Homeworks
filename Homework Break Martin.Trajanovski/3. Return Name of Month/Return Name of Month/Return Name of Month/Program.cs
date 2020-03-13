using System;

namespace Return_Name_of_Month
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number from 1 - 12");
            string inputNumber = Console.ReadLine();
            double num;
            bool isParsedOne = double.TryParse(inputNumber, out num);
            while (!isParsedOne || num > 12 || num < 1)
            {
                    Console.WriteLine("Please enter a number from 1 - 12");
                    inputNumber = Console.ReadLine();
                    isParsedOne = double.TryParse(inputNumber, out num);
                                   
            } 
            if (isParsedOne)
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine("January");
                        break;
                    case 2:
                        Console.WriteLine("February");
                        break;
                    case 3:
                        Console.WriteLine("March");
                        break;
                    case 4:
                        Console.WriteLine("April");
                        break;
                    case 5:
                        Console.WriteLine("May");
                        break;
                    case 6:
                        Console.WriteLine("June");
                        break;
                    case 7:
                        Console.WriteLine("July");
                        break;
                    case 8:
                        Console.WriteLine("August");
                        break;
                    case 9:
                        Console.WriteLine("September");
                        break;
                    case 10:
                        Console.WriteLine("October");
                        break;
                    case 11:
                        Console.WriteLine("November");
                        break;
                    case 12:
                        Console.WriteLine("December");
                        break;
                    default:
                        Console.WriteLine("There are only 12months in the year!");
                        break;
                }
            }
          




            Console.ReadLine();
        }
    }
}
