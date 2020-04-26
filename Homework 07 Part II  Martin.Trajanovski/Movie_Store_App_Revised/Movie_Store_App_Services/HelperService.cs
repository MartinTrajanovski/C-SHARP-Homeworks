using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Store_App_Services
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

        public int ValidatePositiveNumber(string number, int range)
        {
            int result = 0;
            bool isNumber = int.TryParse(number, out result);
            if (!isNumber)
            {
                Console.WriteLine("You must enter a number. Press enter to try again!");
                Console.ReadLine();
                Console.Clear();
                return -1;
            }
            if (result < 1 || result > range)
            {
                Console.WriteLine("The number is out of range. Press enter to try again!");
                Console.ReadLine();
                Console.Clear();
                return -1;
            }
            return result;
        }
        public int ValidatePhoneNumber(string number)
        {
           int result = 0;
            bool isNumber = int.TryParse(number, out result);
            if (!isNumber)
            {
                Console.WriteLine("You must enter a number. Press enter to try again!");
                Console.ReadLine();
                Console.Clear();
                return -1;
            }
            if (Math.Floor(Math.Log10(result) + 1) != 9)
            {
                Console.WriteLine("The number is out of range. Press enter to try again!");
                Console.ReadLine();
                Console.Clear();
                return -1;
            }
            return result;
        }
        public bool DifferentUser()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Would you like to login with another username? Y/N");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y") return true;
                if (answer == "n") return false;
            }
        }
        public bool DifferentTasks()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Would you like to perform other tasks? Y/N");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y") return true;
                if (answer == "n") return false;
            }
        }
        public bool ContinueRenting()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Would you like to rent another movie? Y/N");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y") return true;
                if (answer == "n") return false;
            }
        }
        public bool ContinueDeleting()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Would you like to delete another member? Y/N");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y") return true;
                if (answer == "n") return false;
            }
        }
    }
}
