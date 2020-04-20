using Movie_Store_App_Domain_Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Store_App_Domain_Models.Members
{
    public class User : Member
    {
        public int MemberNumber { get; set; }
        public SubscriptionType SubscriptionType { get; set; }
        public DateTime EndOfRegistration { get; set; }
        public Movie[] Movies { get; set; }

        public User()
        {
            DateOfRegistration = DateTime.Now;
            if (SubscriptionType == SubscriptionType.Annual)
            {
                EndOfRegistration = DateTime.Now.AddDays(365);
            }
            else if (SubscriptionType == SubscriptionType.Monthly)
            {
                EndOfRegistration = DateOfRegistration.AddDays(30);
            }
            Role = Role.User;
            Movies = new Movie[0];
        }
        public User(string firstName, string lastName, int age)
        {
            Role = Role.User;
            Movies = new Movie[1];
        }
        public User (string firstName, string lastName, int age, string username, string password, int phoneNumber, SubscriptionType subscriptionType)
           : base (firstName, lastName, age, username, password, phoneNumber)
        {
            
            if(subscriptionType == SubscriptionType.Annual)
            {
                EndOfRegistration = DateOfRegistration.AddYears(1);
            } else if(subscriptionType == SubscriptionType.Monthly)
            {
                EndOfRegistration = DateOfRegistration.AddMonths(1);
            }
            Role = Role.User;
            Movies = new Movie[0];
        }
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
        public void ShowInfo()
        {
            var dateAndTime = DateTime.Now;
            var date = dateAndTime.Date;
            double daysUntilExpiration = Math.Floor((EndOfRegistration - date).TotalDays);
            Console.WriteLine($"Your subscription type is {SubscriptionType} and it ends in {daysUntilExpiration} days.");

        }
    }
}
