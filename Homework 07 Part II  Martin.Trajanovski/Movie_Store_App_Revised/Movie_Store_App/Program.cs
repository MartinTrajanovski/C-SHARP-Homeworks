using Movie_Store_App_Domain_Models.Employee;
using Movie_Store_App_Domain_Models.Enums;
using Movie_Store_App_Domain_Models.Members;
using Movie_Store_App_Services;
using System;

namespace Movie_Store_App
{
    class Program
    {
        private static HelperService helperService = new HelperService();
        private static UserService userService = new UserService();
        private static EmployeeService employeeService = new EmployeeService();
        private static MovieService movieService = new MovieService();
        private static User registeredUser = null;
        private static User loggedUser = null;
        private static Employee loggedEmployee = null;

        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                int roleChoice;
                while (true)
                {
                    Console.WriteLine("Welcome to our Movie Store!");
                    Console.WriteLine("Are you an employee, or a customer?");
                    Console.WriteLine("1) Employee\n2) Customer");
                    roleChoice = helperService.ValidatePositiveNumber(Console.ReadLine(), 2);
                    if (roleChoice != 1 && roleChoice != 2)
                    {
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Welcome! Press Enter to continue...");
                        Console.ReadLine();
                        break;
                    }
                }
                if (roleChoice == 1)
                {
                    DateTime timeOfLogin;
                    DateTime timeOfLogout;
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Enter username!");
                        string user = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Enter password!");
                        string password = Console.ReadLine();
                        loggedEmployee = employeeService.LogIn(user, password);
                        if (loggedEmployee == null)
                        {
                            helperService.ErrorMessage("Wrong username or password!");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            timeOfLogin = DateTime.Now;
                            break;
                        }
                    }


                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine($"Welcome {loggedEmployee.FullName()}");
                        Console.WriteLine($"Please choose one of the following options:");
                        Console.WriteLine($"1) See all registered members\n2) See all available movies\n3) Add new member\n4) Delete an existing member\n5) See salary and working hours info");
                        int employeeTask = helperService.ValidatePositiveNumber(Console.ReadLine(), 5);
                        if (employeeTask < 1 || employeeTask > 6)
                        {
                            helperService.ErrorMessage("Please choose a number between 1 and 5! Press Enter to try again");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            if (employeeTask == 1)
                            {
                                Console.Clear();
                                userService.PrintAllMembers();
                                Console.ReadLine();
                            }
                            else if (employeeTask == 2)
                            {
                                Console.Clear();
                                movieService.PrintAllMovies();
                                Console.ReadLine();
                            }
                            else if (employeeTask == 3)
                            {
                                while (true)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Enter your first name! It must not be shorter than 2 characters!");
                                    string firstName = Console.ReadLine();
                                    Console.Clear();
                                    Console.WriteLine("Enter your last name! It must not be shorter than 2 characters!");
                                    string lastName = Console.ReadLine();
                                    Console.Clear();
                                    Console.WriteLine("Enter your username! It must not be shorter than 5 characters!");
                                    string username = Console.ReadLine();
                                    Console.Clear();
                                    Console.WriteLine("Enter your password!");
                                    string passWord = Console.ReadLine();
                                    Console.Clear();
                                    Console.WriteLine("Enter your age!");
                                    int age = helperService.ValidatePositiveNumber(Console.ReadLine(), 99);
                                    Console.Clear();
                                    Console.WriteLine("Enter your phone number! It must be 9 digits long");
                                    int phoneNumber = helperService.ValidatePhoneNumber(Console.ReadLine());
                                    Console.Clear();
                                    Console.WriteLine("Please choose your subscription type!\n1)Annual\n2)Monthly");
                                    int subscription = helperService.ValidatePositiveNumber(Console.ReadLine(), 2);

                                    if (subscription == 1)
                                    {
                                        User newUser = new User(firstName, lastName, age, username, passWord, phoneNumber, SubscriptionType.Annual);
                                        newUser.SubscriptionType = SubscriptionType.Annual;
                                        registeredUser = userService.Register(newUser);
                                        if (registeredUser == null)
                                        {
                                            Console.Clear();
                                            helperService.ErrorMessage("Something went wrong! Please try again...");
                                            Console.ReadLine();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine($"Welcome {registeredUser.DisplayInfo()}");
                                            newUser.ShowInfo();
                                            Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    }
                                    else if (subscription == 2)
                                    {
                                        User newUser = new User(firstName, lastName, age, username, passWord, phoneNumber, SubscriptionType.Monthly);
                                        newUser.SubscriptionType = SubscriptionType.Monthly;
                                        registeredUser = userService.Register(newUser);
                                        if (registeredUser == null)
                                        {
                                            Console.Clear();
                                            helperService.ErrorMessage("Something went wrong! Please try again...");
                                            Console.ReadLine();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine($"Welcome {registeredUser.DisplayInfo()}");
                                            newUser.ShowInfo();
                                            Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        helperService.ErrorMessage("Something went wrong! Please try again...");
                                        Console.ReadLine();
                                    }
                                }
                            }
                            else if (employeeTask == 4)
                            {
                                userService.DeleteMembers();
                                Console.ReadLine();
                            } else if(employeeTask == 5)
                            {
                                loggedEmployee.SetSalary();
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Choose a number between 1 and 5. Press Enter to try again...");
                                Console.ReadLine();
                            }
                        }
                        if (helperService.DifferentTasks() == false)
                        {
                            timeOfLogout = DateTime.Now;
                            loggedEmployee.HoursPerMonth += Math.Floor((timeOfLogout - timeOfLogin).TotalHours);
                            Console.Clear();
                            break;
                        }
                        
                    }

                }
                else if (roleChoice == 2)
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Enter username!");
                        string user = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Enter password!");
                        string password = Console.ReadLine();
                        loggedUser = userService.LogIn(user, password);
                        if (loggedUser == null)
                        {
                            Console.Clear();
                            helperService.ErrorMessage("Wrong username or password!");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            break;
                        }
                    }

                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine($"Welcome {loggedUser.GetFullName()}");
                        Console.WriteLine($"Please choose one of the following options:");
                        Console.WriteLine($"1) See you subscription info\n2) Rent a movie\n3) See all your rented movies");
                        int userTask = helperService.ValidatePositiveNumber(Console.ReadLine(), 3);
                        if (userTask < 1 || userTask > 3)
                        {
                            Console.Clear();
                            helperService.ErrorMessage("Please choose a number between 1 and 3! Press Enter to try again");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            if (userTask == 1)
                            {
                                Console.Clear();
                                loggedUser.ShowInfo();
                                Console.ReadLine();
                            }
                            else if (userTask == 2)
                            {
                                Console.Clear();
                                movieService.RentLogic(loggedUser);
                                Console.ReadLine();
                            }
                            else if (userTask == 3)
                            {
                                Console.Clear();
                                movieService.PrintRentedMovies(loggedUser);
                                Console.ReadLine();
                            }
                        }
                        if (helperService.DifferentTasks() == false) break;
                        Console.Clear();
                    }
                }
                if (helperService.DifferentUser() == false) break;
                Console.Clear();
            }




        }
    }
}
