using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Shelter.Services
{
    public class HelperService
    {
        public void ErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public bool ValidateStringLength(string value, int range)
        {
            int maxValue = 20;
            if (value.Length < range && range < maxValue)
                return false;
            return true;
        }
        public int ValidateMaturity(string number, int range)
        {
            int age;
            bool isNumber = int.TryParse(number, out age);
            if (!isNumber)
            {
                Console.WriteLine("You must enter a number!");
                Console.Clear();
                return -1;
            }
            if (age < 1 || age < range)
            {
               ErrorMessage("You are underage. You are not allowed to adopt animals!");
                return -1;
            }
            return age;
        }
        public int ValidatePositiveNumber(string number, int range)
        {
            int result = 0;
            bool isNumber = int.TryParse(number, out result);
            if (!isNumber)
            {
                ErrorMessage("You must enter a number! Press Enter to try again!");
                Console.ReadLine();
                Console.Clear();
                return -1;
            }
            if (result < 1 || result > range)
            {
                Console.WriteLine("The number is out out of range. Press Enter to try again...");
                Console.ReadLine();
                Console.Clear();
                return -1;
            }
            return result;
        }
        public bool RunAgain()
        {
            while (true)
            {
                Console.WriteLine("Adopt some more animals? Y/N");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y") return true;
                if (answer == "n") return false;
            }

        }
    }
}
