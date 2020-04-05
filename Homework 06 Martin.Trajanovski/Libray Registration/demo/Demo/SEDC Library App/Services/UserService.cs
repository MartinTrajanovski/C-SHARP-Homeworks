using System;
using System.Collections.Generic;
using System.Text;
using SEDC_Library_App.Domain;

namespace SEDC_Library_App.Services
{
   public class UserService
    {
        private HelperService helperService = new HelperService();
        public User[] Users { get; set; }
        public UserService()
        {
            Users = new User[]
            {
                new User()
                {
                    FirstName = "Martin",
                    LastName = "Trajanovski",
                    Username = "martin_trajan",
                    Password = "neznamKako1",
                    Role = "admin"
                },
                new User()
                {
                    FirstName = "Marko",
                    LastName = "Trajanovski",
                    Username = "marko_traj",
                    Password = "neznamKako2",
                    Role = "user"
                }
            };
        }


        // Validate Pass
        public bool ValidatePassword(string password)
        {
            if (password.Length < 7) return false;
            char[] characters = password.ToCharArray();
            bool hasNumber = false;
            foreach (char character in characters)
            {
                int num = 0;
                if (int.TryParse(character.ToString(), out num))
                {
                    hasNumber = true; break;
                }
            }
            if (!hasNumber) return false;
            return true;
        }
        //Login Method
        public User LogIn (string username, string password)
        {
            foreach (User user in Users)
            {
                if (user.Username == username && user.Password == password)
                    return user;
            }
            return null;
        }





        //Register Method
        public User Register (User user)
        {
            //validation
            if(! helperService.ValidateStringLength(user.FirstName, 2) || ! helperService.ValidateStringLength(user.LastName, 2) ||
                ! helperService.ValidateStringLength(user.Username, 5))
            {
                return null;
            }
            if (!ValidatePassword(user.Password)) 
                return null;

            User[] newArray = Users;
            Array.Resize(ref newArray, newArray.Length + 1);
            newArray[newArray.Length - 1] = user;
            Users = newArray;

            return Users[Users.Length - 1];
        }

        public void PrintUsers ()
        {
            foreach (User user in Users)
            {
                Console.WriteLine($"{user.FirstName} {user.LastName}");
            }
        }

    }
}
