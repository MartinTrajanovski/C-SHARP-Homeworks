using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Shelter.Domain
{
    public class Owner
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public Animal[] Pets  { get; set; }
        public string City { get; set; }
        public Owner()
        {
            Pets = new Animal[0];
        }

        public string GetFullInfo()
        {
            return $"{FirstName} {LastName} lives in the city of {City} at {Address}.";
        }
    }
}
