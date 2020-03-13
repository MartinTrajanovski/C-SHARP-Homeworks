using System;

namespace FlipTheBoolean
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Please Enter Either True or False!");
            string userInput = Console.ReadLine();
            bool result;

            if (userInput.ToLower() == "true")
            {
                result = false;
                Console.WriteLine(result);
            } else if (userInput.ToLower() == "false")
            {
                result = true;
                Console.WriteLine(result);
            } else
            {
                Console.WriteLine("Error, incorrect value!");
            }
            Console.ReadLine();
        }
    }
}
