using Movie_Store_App_Domain_Models.Members;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Store_App_Domain_Models.Employee
{
   public class Employee : Member
    {
        protected double Salary { get; set; }
        public int HoursPerMonth { get; set; }
        public double? Bonus { get; set; }

        public Employee()
        {
            Role = Role.Employee;
        }
        public Employee (string firstName, string lastName, int age, string username, string password, int phoneNumber)
            :base(firstName, lastName, age, username, password, phoneNumber)
        {
            Role = Role.Employee;
            Salary = 300;
        }
        public void SetBonus()
        {
            if (HoursPerMonth > 160)
            {
               Bonus = 0.3;
            } else
            {
               Bonus = null;
            }
        }
        public void SetSalary()
        {
            SetBonus();
            if(Bonus == null)
            {
                Salary = 300;
            } else
                Salary = 300 + (HoursPerMonth * 0.3);
        }
        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
