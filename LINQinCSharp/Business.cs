using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQinCSharp
{
    internal class Business
    {
        class Employee
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public string Department { get; set; }

            public int Salary { get; set; }

        }

        public void ManipulateLINQ()
        {
            IEnumerable<Employee> employees = new List<Employee>()
            {
                
                new Employee {Id = 1, Name="MaryAnn", Department="Business", Salary= 2000},
                new Employee {Id = 2, Name="Don", Department="Business", Salary= 1000000},
               
            };

            Console.WriteLine("The Business employees and their salaries are : ");
            var employeeSalaries = employees.OrderByDescending(emp => emp.Salary);
            foreach (var employeeSalary in employeeSalaries)
            {
                Console.WriteLine($"{employeeSalary.Name} : {employeeSalary.Salary}");
                
            }
        }
    }
}
