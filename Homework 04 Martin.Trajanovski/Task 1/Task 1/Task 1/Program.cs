using System;

namespace Task_1
{
    class Program
    {
        static void Substring()
        {
            string testString = "Hello from SEDC Codecademy v7.0";
            int testStringLength = testString.Length;
            Console.WriteLine($"Please enter a number between 1 and {testStringLength}");
            string userNumber = Console.ReadLine();
            int convertedNumber;
            bool isUserNumberParsed = int.TryParse(userNumber, out convertedNumber);
            while (true)
            {
                if (isUserNumberParsed)
                {
                    if (convertedNumber >= 1 && convertedNumber <= testStringLength)
                    {
                        string resultString = testString.Substring(0, convertedNumber);
                        Console.Clear();
                        Console.WriteLine($"The new string is {resultString}!");
                        Console.WriteLine($"The length of the new string is {resultString.Length} characters!");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter a number between 1 and 31");
                        userNumber = Console.ReadLine();
                        isUserNumberParsed = int.TryParse(userNumber, out convertedNumber);
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a number between 1 and 31");
                    userNumber = Console.ReadLine();
                    isUserNumberParsed = int.TryParse(userNumber, out convertedNumber);
                }
            }
        }
        static void Main(string[] args)
        {
            Substring();
            Console.ReadLine();
        }
    }
}
