using Animal_Shelter.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animal_Shelter.Services
{
    public class AnimalService
    {
        private static HelperService helperService = new HelperService();
        private static AnimalService animalService = new AnimalService();
        public Animal[] Animals { get; set; }
        public AnimalService()
        {
            Animals = new Animal[]
            {
                new Animal()
                {
                    Name = "Fidan",
                    Species = "Horse",
                    Color = "Brown"
                },
                new Animal()
                {
                    Name = "Rajko",
                    Species = "Donkey",
                    Color = "Gray"
                },
                new Animal()
                {
                    Name = "Evrosima",
                    Species = "Goat",
                    Color = "White"
                },
                new Animal()
                {
                    Name = "Erazmo",
                    Species = "Ram",
                    Color = "White"
                },
                new Animal()
                {
                    Name = "Petkana",
                    Species = "Cow",
                    Color = "White"
                }
            };
        }
        public void PrintAllAnimals()
        {
            if (Animals.Length == 0)
            {
                Console.WriteLine("There are no animals in the shelter!");
                return;
            } else
            {
                foreach (Animal animal in Animals)
                {
                    int ordinal = Array.IndexOf(Animals, animal);
                    Console.WriteLine($"{ordinal + 1}. {animal.AnimalInfo()}");
                }
                
            }
        }
        public void ExcludeChosenAnimal(int animalToRemove)
        {
            if (Animals.Length == 0)
            {
                Console.WriteLine("There are no animals in the shelter!");
                return;
            }
            else
            {
                Animals = Animals.Where((source, index) => index != animalToRemove - 1).ToArray();
            }
        }
        public Animal AddAnimalsAsPets(int selectedAnimal, Owner owner)
        {
            Animal[] newarray = owner.Pets;
            Array.Resize(ref newarray, newarray.Length + 1);
            newarray[newarray.Length - 1] = Animals[selectedAnimal - 1];
            owner.Pets = newarray;
            return owner.Pets[owner.Pets.Length-1];
        }
        public void PrintPets(Owner owner)
        {
            foreach (Animal animal in owner.Pets)
            {
                int ordinal = Array.IndexOf(owner.Pets, animal);
                Console.WriteLine($"{ordinal + 1}. {animal.AnimalInfo()}");
            }
        }
        public void AdoptionLogic(Owner owner)
        { 
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Please choose an animal. Enter a number between 1 and {Animals.Length}");
                PrintAllAnimals();
                int chosenAnimal = helperService.ValidatePositiveNumber(Console.ReadLine(), Animals.Length);
                if (chosenAnimal >=1 && chosenAnimal <= Animals.Length)
                {
                   if (helperService.RunAgain() == true)
                   {
                        AddAnimalsAsPets(chosenAnimal, owner);
                        ExcludeChosenAnimal(chosenAnimal);
                          if (Animals.Length == 0)
                          {
                              Console.Clear();
                              Console.WriteLine("There are no more animals in the adoption center! These are your adopted animals:");
                              PrintPets(owner);
                              break;
                          }
                   }
                   else
                   {
                        Console.Clear();
                        AddAnimalsAsPets(chosenAnimal, owner);
                        Console.WriteLine("These are your adopted animals:");
                        PrintPets(owner);
                        break;
                   }
                }
            }
        }
    }
}
