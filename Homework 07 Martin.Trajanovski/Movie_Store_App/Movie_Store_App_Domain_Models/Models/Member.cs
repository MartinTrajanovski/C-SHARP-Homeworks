using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Store_App_Domain_Models.Members
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int PhoneNumber{ get; set; }
        public DateTime DateOfRegistration { get; set; }
        public Role Role{ get; set; }

        public Member()
        {
           
        }


        public Member(string firstName, string lastName, int age, string username, string password, int phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Username = username;
            Password = password;
            PhoneNumber = phoneNumber;
            DateOfRegistration = DateTime.Now;
        }
        public string DisplayInfo()
        {
            return $"{FirstName} {LastName} | Registered on: {DateOfRegistration}";
        }
    }
}
