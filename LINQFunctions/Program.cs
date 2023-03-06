using LINQFunctions.Data;
using System;
using System.Linq;

namespace LINQFunctions
{
    class Program
    {
        static void Main(string[] args)
        {

            //var employees = from employee in Employee.GetEmployees()
            //                orderby employee.Gender descending, employee.Name
            //                select employee;

            var employees = Employee.GetEmployees().OrderByDescending(e => e.Gender).ThenBy(e => e.Name);


            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Name + " " + employee.Gender + " " + employee.City);
            }

            Console.ReadLine();
        }
    }
}
