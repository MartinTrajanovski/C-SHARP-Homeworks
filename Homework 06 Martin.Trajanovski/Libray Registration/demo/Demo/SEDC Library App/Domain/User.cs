using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC_Library_App.Domain
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public User()
        {
            //ctor tab tab
            Role = "user";


        }

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
