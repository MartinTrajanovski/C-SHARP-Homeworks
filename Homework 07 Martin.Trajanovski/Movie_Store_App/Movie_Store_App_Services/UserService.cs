using Movie_Store_App_Domain_Models.Enums;
using Movie_Store_App_Domain_Models.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Movie_Store_App_Services
{
   public class UserService
    {
        public User[] Users { get; set; }
        private HelperService helperService = new HelperService();

        public UserService()
        {
            Users = new User[]
            {
                new User()
                {
                    FirstName = "Marko",
                    LastName = "Trajanovski",
                    Age = 28,
                    Username = "marko_marko",
                    Password = "marko123",
                    PhoneNumber = 123789,
                    Movies = new Movie[]
                    {
                        new Movie()
                        {
                            Title = "The Death of Mr. Lazarescu",
                            Description = "A social satire about the Romanian health care system",
                            Year = 2005,
                            Genre = Genres.Drama
                        }
                    },
                    DateOfRegistration = new DateTime(2019, 12, 04),
                    EndOfRegistration = new DateTime(2022, 12, 04),
                    SubscriptionType = SubscriptionType.Monthly
                },
                new User()
                {
                    FirstName = "Jovo",
                    LastName = "Jovevski",
                    Age = 31,
                    Username = "jovo_jovo",
                    Password = "jovo123",
                    PhoneNumber = 123789,
                    Movies = new Movie[]
                    {
                        new Movie()
                        {
                            Title = "The Apostle",
                            Description = "A character study of a Southern preacher whose undisturbed life suddenly spins out of control",
                            Year = 1997,
                            Genre = Genres.Drama
                        }
                    },
                    DateOfRegistration = new DateTime(2014, 12, 04),
                    EndOfRegistration = new DateTime(2021, 12, 04),
                    SubscriptionType = SubscriptionType.Annual
                },
                new User()
                {
                    FirstName = "Jovana",
                    LastName = "Jovanovska",
                    Age = 89,
                    Username = "jovana_jovana",
                    Password = "jovana123",
                    PhoneNumber = 123789,
                    Movies = new Movie[]
                    {
                        new Movie()
                        {
                            Title = "Loveless",
                            Description = "A Russian drama about a couple stuck in a loveless marriage who has to join forces to look for their son who has vanished during one of their arguments",
                            Year = 2017,
                            Genre = Genres.Drama
                        }
                    },
                    DateOfRegistration = new DateTime(2018, 12, 04),
                    EndOfRegistration = new DateTime(2020, 12, 04),
                    SubscriptionType = SubscriptionType.Annual
                    
                },
            };
        }
        public void PrintAllMembers()
        {
            foreach (User user in Users)
            {
                int ordinal = Array.IndexOf(Users, user);
                Console.WriteLine($"{ordinal+1}. {user.FirstName} {user.LastName}");
            }
        }
        public User LogIn(string username, string password)
        {
            foreach (User user in Users)
            {
                if (user.Username == username && user.Password == password)
                    return user;
            }
            return null;
        }
        public void DeleteMembers()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Please choose a member. Enter a number between 1 and {Users.Length}");
                PrintAllMembers();
                int chosenMember = helperService.ValidatePositiveNumber(Console.ReadLine(), Users.Length);
                if (chosenMember >= 1 && chosenMember <= Users.Length)
                {
                    if (helperService.RunAgain() == true)
                    {
                        Users = Users.Where((source, index) => index != chosenMember - 1).ToArray();
                        if (Users.Length == 0)
                            {
                            Console.WriteLine("You deleted all members!");
                            break;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Users = Users.Where((source, index) => index != chosenMember - 1).ToArray();
                        Console.WriteLine("These are the remaining members:");
                        PrintAllMembers();
                        break;
                    }
                }
            }
        }
        
        //public User AddNewMember()
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("Enter your first name! It must not be shorter than 2 characters!");
        //        string firstName = Console.ReadLine();
        //        Console.Clear();
        //        Console.WriteLine("Enter your last name! It must not be shorter than 2 characters!");
        //        string lastName = Console.ReadLine();
        //        Console.Clear();
        //        Console.WriteLine("Enter your username! It must not be shorter than 5 characters!");
        //        string username = Console.ReadLine();
        //        Console.WriteLine("Enter your password!");
        //        string password = Console.ReadLine();
        //        Console.WriteLine("Enter your age!");
        //        int age = helperService.ValidatePositiveNumber(Console.ReadLine(), 99);
        //        Console.WriteLine("Enter your phone number! It must be 9 digits long");
        //        int phoneNumber = helperService.ValidatePhoneNumber(Console.ReadLine(), 99);
        //        Console.WriteLine("Please choose your subscription type!\n1)Annual\n2)Monthly");
        //        int subscription = helperService.ValidatePositiveNumber(Console.ReadLine(), 2);
        //        if (subscription == 1)
        //        {
        //            User newUser = new User(firstName, lastName, age, username, password, phoneNumber, SubscriptionType.Annual);
        //            break;

        //        }
        //        else
        //        {
        //            User newUser = new User(firstName, lastName, age, username, password, phoneNumber, SubscriptionType.Monthly);
        //            break;
        //        }
        //    }
        //}

        public User Register(User user)
        {
            //validation
            if (!helperService.ValidateStringLength(user.FirstName, 2) || !helperService.ValidateStringLength(user.LastName, 2) ||
                !helperService.ValidateStringLength(user.Username, 5))
            {
                return null;
            }

            User[] newArray = Users;
            Array.Resize(ref newArray, newArray.Length + 1);
            newArray[newArray.Length - 1] = user;
            Users = newArray;

            return Users[Users.Length - 1];
        }
    }
}
