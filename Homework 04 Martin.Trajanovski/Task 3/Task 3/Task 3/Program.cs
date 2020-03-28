using System;

namespace Task_3
{
    class Program
    {
        static DateTime GetData ()
        {
            int year;
            int month;
            int day;
            DateTime today = DateTime.Now;
            int currentYear = today.Year;
            while (true)
            {
                Console.WriteLine("Please enter the year of your birth!");
                string birthYear = Console.ReadLine();
                bool isBirthYearParsed = int.TryParse(birthYear, out year);
                if (isBirthYearParsed)
                {
                    if (year > 1900 && year < currentYear)
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you!");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter a valid birth year! Press Enter to try again...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a valid birth year! Press Enter to try again...");
                    Console.ReadLine();
                    Console.Clear();
                }

            }
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please enter the month of your birth (number between 1 - 12)");
                string birthMonth = Console.ReadLine();
                bool isBirthMonthParsed = int.TryParse(birthMonth, out month);
                if (isBirthMonthParsed)
                {
                    if (month >= 1 && month <= 12)
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you!");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter a valid birth month! Press Enter to try again...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a valid birth month! Press Enter to try again...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            while (true)
            {
                if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter the day of your birth (Number between 1 - 31)!");
                    string birthDay = Console.ReadLine();
                    bool isBirthDayParsed = int.TryParse(birthDay, out day);
                    if (isBirthDayParsed)
                    {
                        if (day >= 1 && day <= 31)
                        {
                            Console.Clear();
                            Console.WriteLine("Thank you!");
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a valid birth day! Press Enter to try again...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter a valid birth day! Press Enter to try again...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter the day of your birth (Number between 1 - 30)!");
                    string birthDay = Console.ReadLine();
                    bool isBirthDayParsed = int.TryParse(birthDay, out day);
                    if (isBirthDayParsed)
                    {
                        if (day >= 1 && day <= 30)
                        {
                            Console.Clear();
                            Console.WriteLine("Thank you!");
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a valid birth day! Press Enter to try again...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter a valid birth day! Press Enter to try again...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                if (month == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter the day of your birth (Number between 1 - 29)!");
                    string birthDay = Console.ReadLine();
                    bool isBirthDayParsed = int.TryParse(birthDay, out day);
                    if (isBirthDayParsed)
                    {
                        if (day >= 1 && day <= 29)
                        {
                            Console.Clear();
                            Console.WriteLine("Thank you!");
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a valid birth day! Press Enter to try again...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter a valid birth day! Press Enter to try again...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
            }
            DateTime birthday = new DateTime(year, month, day);
            return birthday;
        }
        static int AgeCalculator (DateTime birthday)
        {
            DateTime today = DateTime.Now;
            int currentYear = today.Year;
            int currentMonth = today.Month;
            int currentDay = today.Day;
            int yearOfBirth =  birthday.Year;
            int monthOfBirth = birthday.Month;
            int dayOfBirth = birthday.Day;
            int age;
            if (monthOfBirth > currentMonth)
            {
                age = currentYear - yearOfBirth - 1;
                Console.WriteLine($"You are {age} years old!");
                return age;
            }
            if (monthOfBirth <= currentMonth && dayOfBirth < currentDay)
            {
                age = currentYear - yearOfBirth;
                Console.WriteLine($"You are {age} years old!");
                return age;
            }
            if (monthOfBirth <= currentMonth && dayOfBirth > currentDay)
            {
                age = currentYear - yearOfBirth - 1;
                Console.WriteLine($"You are {age} years old!");
                return age;
            }
            if (monthOfBirth == currentMonth && dayOfBirth > currentDay)
            {
                age = currentYear - yearOfBirth - 1;
                Console.WriteLine($"You are {age} years old!");
                return age;
            }
            if (monthOfBirth == currentMonth && dayOfBirth == currentDay)
            {
                age = currentYear - yearOfBirth;
                Console.WriteLine($"Happy Birthday! You are {age} today!!!");
                return age;
            }
                return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(AgeCalculator(GetData()));
            Console.ReadLine();
        }
    }
}
