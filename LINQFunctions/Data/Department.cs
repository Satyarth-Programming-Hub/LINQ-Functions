using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQFunctions.Data
{
    class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<Department> GetDepartment()
        {
            List<Department> departmentsList = new List<Department>()
            {
                new Department(){ Id=1, Name="Accounts" },
                new Department(){ Id=2, Name="Data Science" },
                new Department(){ Id=3, Name="Information Technology" },
                new Department(){ Id=4, Name="Computer Science" },
                new Department(){ Id=5, Name="Electronics" },
            };
            return departmentsList;
        }
    }
}
