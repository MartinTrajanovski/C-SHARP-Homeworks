using Movie_Store_App_Domain_Models.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Store_App_Services
{
    public class EmployeeService
    {
        public Employee[] Employees { get; set; }
        private HelperService helperService = new HelperService();

        public EmployeeService()
        {
            Employees = new Employee[]
            {
                new Employee()
                {
                    FirstName = "Martin",
                    LastName = "Trajanoski",
                    Age = 26,
                    Username = "martin_martin",
                    Password = "martin123",
                    PhoneNumber = 123456
                }
            };
        }

        public Employee LogIn(string username, string password)
        {
            foreach (Employee employee in Employees)
            {
                if (employee.Username == username && employee.Password == password)
                    return employee;
            }
            return null;
        }

        
        public Employee Register(Employee employee)
        {
            
            if (!helperService.ValidateStringLength(employee.FirstName, 2) ||
               !helperService.ValidateStringLength(employee.LastName, 2) ||
               !helperService.ValidateStringLength(employee.Username, 5))
            {
                return null;
            }

            Employee[] newArr = Employees;
            Array.Resize(ref newArr, newArr.Length + 1);
            newArr[newArr.Length - 1] = employee;
            Employees = newArr;

            return Employees[Employees.Length - 1];
        }
    }
}
