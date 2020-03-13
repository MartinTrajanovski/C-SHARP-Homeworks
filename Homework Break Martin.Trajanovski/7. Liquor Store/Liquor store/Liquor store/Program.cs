using System;

namespace Liquor_store
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our liquor store!");
            Console.WriteLine("What is your name?");
            string fName = Console.ReadLine();
            Console.WriteLine("How about your last name?");
            string lName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            string ageInput = Console.ReadLine();
            int age;
            string drink;
            bool isAgeParsed = int.TryParse(ageInput, out age);
            if (isAgeParsed)
            {
                if (age >= 18)
                {
                    Console.WriteLine("What would you like to buy?");
                    drink = Console.ReadLine();
                    Console.WriteLine($"Dear {fName} {lName}, here's your bottle of {drink}. Have a nice day!");
                } 
                else
                {
                    Console.WriteLine($"Dear {fName} {lName}, I am sorry but you are not allowed to buy alchocol!");
                }
            } else
            {
                Console.WriteLine("Please enter a valid age!");
            }


            Console.ReadLine();
        }
    }
}
