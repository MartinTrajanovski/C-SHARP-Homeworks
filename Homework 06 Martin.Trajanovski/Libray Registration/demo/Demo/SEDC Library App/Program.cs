using SEDC_Library_App.Domain;
using SEDC_Library_App.Services;
using System;

namespace SEDC_Library_App
{
    //1. Folder structure for the app
    //2. Create domain classes User and Book
    //3. Create User and Book service
    //4. Write login and register questions
    //5. Create a login and register method in the user service, as well as an array of users
    //6. To validate things, create a helper service
    //7. Implement login and register methods in user service
    //8. Implement get all books method in the book service
    class Program
    {
        private static UserService userService = new UserService();
        private static BookService bookService = new BookService();
        private static HelperService helperService = new HelperService();
        private static User loggedUser = null;
        private static User registeredUser = null;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Do you wany to login or register?");
                Console.WriteLine("1) Login");
                Console.WriteLine("2) Register");
                int logInChoice = helperService.ValidatePositiveNumber(Console.ReadLine(), 2);

               if (logInChoice == 1)
                {
                    while(true)
                    {
                        Console.Clear();
                        Console.WriteLine("Enter username!");
                        string user = Console.ReadLine();
                        Console.WriteLine("Enter password!");
                        string password = Console.ReadLine();

                        loggedUser = userService.LogIn(user, password);

                        if(loggedUser == null)
                        {
                            helperService.ErrorMessage("Wrong username or password!");
                            Console.ReadLine();
                            Console.Clear();
                        } else if (loggedUser.Role == "user")
                        {
                            Console.Clear();
                            Console.WriteLine($"Welcome {loggedUser.FullName()}\nHere are all the books available:");
                            bookService.PrintAllBooks();
                            break;
                        } else if (loggedUser.Role == "admin")
                        {
                            Console.Clear();
                            Console.WriteLine($"Welcome {loggedUser.FullName()}!\nHere are all registered users:");
                            userService.PrintUsers();
                            break;
                        } else
                        {
                             helperService.ErrorMessage("Something went wrong");
                        }
                    }
                } else if (logInChoice == 2)
                {
                    while(true)
                    {
                        Console.Clear();
                        Console.WriteLine("Enter your first name! It must not be shorter than 2 characters!");
                        string firstName = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Enter your last name! It must not be shorter than 2 characters!");
                        string lastName = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Choose a username! It must not be shorter than 5 characters!");
                        string username = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Choose a password! It must not be shorter than 7 characters and it has to include at least one digit!");
                        string password = Console.ReadLine();
                        User newUser = new User();
                        newUser.FirstName = firstName;
                        newUser.LastName = lastName;
                        newUser.Username = username;
                        newUser.Password = password;

                        registeredUser = userService.Register(newUser);
                        if (registeredUser == null)
                        {
                            helperService.ErrorMessage("Something went wrong! Please try again...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"Welcome {newUser.FullName()}!\nHere are all the books available:");
                            bookService.PrintAllBooks();
                            break;
                        }
                    }
                } else
                {
                    helperService.ErrorMessage("Please enter either 1 or 2! Press enter to try again...");
                    Console.ReadLine();
                    Console.Clear();
                }
                if (helperService.RunAgain() == false)
                    break;
                    Console.Clear();
            }
        }
    }
}
