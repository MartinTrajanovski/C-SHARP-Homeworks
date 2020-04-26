using Movie_Store_App_Domain_Models.Members;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Store_App_Domain_Models.Employee
{
    public class Employee : Member
    {
        protected double Salary { get; set; }
        public double HoursPerMonth { get; set; }
        public double? Bonus { get; set; }

        public Employee()
        {
            Role = Role.Employee;
        }
        public Employee(string firstName, string lastName, int age, string username, string password, int phoneNumber)
            : base(firstName, lastName, age, username, password, phoneNumber)
        {
            Role = Role.Employee;
            Salary = 300;
        }
        public void SetBonus()
        {
            if (HoursPerMonth > 160)
            {
                Bonus = 0.3;
            }
            else
            {
                Bonus = null;
            }
        }
        public void SetSalary()
        {
            Console.Clear();
            SetBonus();
            if (Bonus == null)
            {
                Salary = Salary;
                Console.WriteLine($"So far this month, you have earned {Salary} euros and worked {HoursPerMonth} hours!");
            }
            else
            {
                Salary += (HoursPerMonth * 0.3);
                Console.WriteLine($"So far this month, you have earned {Salary} euros and worked {HoursPerMonth} hours!");
            }
                
        }
        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
