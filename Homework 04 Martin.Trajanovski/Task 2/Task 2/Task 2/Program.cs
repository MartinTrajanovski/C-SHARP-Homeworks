using System;

namespace Task_2
{
    class Program
    {
        static void PrintDates()
        {
            DateTime today = DateTime.Now;
            DateTime aMonthLater = today.AddMonths(1);
            Console.WriteLine($"The date a month from now will be: {aMonthLater}!");
            DateTime aMonthAndThreeDaysLater = aMonthLater.AddDays(3);
            Console.WriteLine($"The date a month and three days from now will be: {aMonthAndThreeDaysLater}!");
            DateTime yearAgo = today.AddYears(-1);
            DateTime aYearAndTwoMonthAgo = yearAgo.AddMonths(-2);
            Console.WriteLine($"The date a year and two months ago was: {aYearAndTwoMonthAgo}!");
            string month = today.ToString("MMMM");
            int year = today.Year;
            Console.WriteLine($"The current month is {month}!");
            Console.WriteLine($"The current year is {year}!");
        }
        static void Main(string[] args)
        {
            PrintDates();





            Console.ReadLine();
        }
    }
}
