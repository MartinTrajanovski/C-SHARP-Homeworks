using Animal_Shelter.Domain;
using Animal_Shelter.Services;
using System;

namespace Animal_Shelter
{
    class Program
    {
        private static OwnerService ownerService = new OwnerService();
        private static AnimalService animalService = new AnimalService();
        private static HelperService helperService = new HelperService();
        private static Owner registeredOwner = null;
       

        static void Main(string[] args)
        {
            Owner newOwner = new Owner();
            while (true)
            {
                Console.WriteLine("Welcome to our Animal Shelter!");
                Console.WriteLine("Enter your first name! It must not be shorter than 2 characters!");
                string firstName = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Enter your last name! It must not be shorter than 2 characters!");
                string lastName = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Enter your address! It must not be shorter than 2 characters!");
                string address = Console.ReadLine();
                Console.WriteLine("Enter your age! You must not be younger than 18!");
                int age = helperService.ValidateMaturity(Console.ReadLine(), 18);

                newOwner.FirstName = firstName;
                newOwner.LastName = lastName;
                newOwner.Address = address;
                newOwner.Age = age;
                registeredOwner = ownerService.Register(newOwner);
                if (newOwner.Age < 18)
                {
                    helperService.ErrorMessage($"We are sorry {newOwner.FirstName} {newOwner.LastName}! See you in a few years!");
                    Console.ReadLine();
                    break;
                }
                else if (registeredOwner == null)
                {
                    helperService.ErrorMessage("Something went wrong! Please try again...");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Welcome {newOwner.FirstName} {newOwner.LastName}! Are you ready to adopt some animals? Press Enter to continue...");
                    Console.ReadLine();
                    animalService.AdoptionLogic(newOwner);
                    break;
                }
            }
            Console.ReadLine();
        }
        
    }
  
}
