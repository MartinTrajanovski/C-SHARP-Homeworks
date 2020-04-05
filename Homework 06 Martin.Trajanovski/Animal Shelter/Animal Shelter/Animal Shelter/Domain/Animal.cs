using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Shelter.Domain
{
   public class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string Color { get; set; }
        public string [] FavouriteFood { get; set; }

        public Owner Owner;
        public Animal()
        {
            FavouriteFood = new string [] { "meat", "snacks"};
        }

        public string Eat(string food)
        {
            return $"{Name} the {Species} wants to eat {food}!";
        }
        public string Sleep(int from, int till)
        {
            return $"{Name} the {Species} wants to sleep from {from} till {till}!";
        }
        public string AnimalInfo()
        {
            return $"{Name} the {Species}";
        }
    }
}
