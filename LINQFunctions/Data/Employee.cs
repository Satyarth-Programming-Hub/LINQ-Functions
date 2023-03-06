using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQFunctions.Data
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public int DepartmentId { get; set; }
        public static List<Employee> GetEmployees()
        {
            List<Employee> employeesList = new List<Employee>()
            {
                new Employee(){Id = 1, Name = "Ramesh", Gender = "Male", Email="ramesh@gamil.com", City="Hyderabad",DepartmentId = 1},
                new Employee(){Id = 2, Name = "Vimla", Gender = "Female", Email="ramesh@gamil.com", City="Noida",DepartmentId = 2},
                new Employee(){Id = 3, Name = "Kamal", Gender = "Male", Email="ramesh@gamil.com", City="Chennai",DepartmentId = 3},
                new Employee(){Id = 4, Name = "Rani", Gender = "Female", Email="ramesh@gamil.com", City="Jaipur",DepartmentId = 4},
                new Employee(){Id = 5, Name = "Rajesh", Gender = "Male", Email="ramesh@gamil.com", City="Delhi",DepartmentId = 5},
                new Employee(){Id = 6, Name = "Seema", Gender = "Female", Email="ramesh@gamil.com", City="Noida",DepartmentId = 1},
                new Employee(){Id = 7, Name = "Sikha", Gender = "Female", Email="ramesh@gamil.com", City="Chennai",DepartmentId = 2},
                new Employee(){Id = 8, Name = "Arif", Gender = "Male", Email="ramesh@gamil.com", City="Jaipur",DepartmentId = 3},
                new Employee(){Id = 9, Name = "Vijendra", Gender = "Male", Email="ramesh@gamil.com", City="Lucknow",DepartmentId = 4},
                new Employee(){Id = 10, Name = "Saleem", Gender = "Male", Email="ramesh@gamil.com", City="Delhi",DepartmentId = 5}
            };
            return employeesList;
        }
    }
}
