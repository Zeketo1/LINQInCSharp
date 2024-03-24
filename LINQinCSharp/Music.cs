using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQinCSharp
{
    internal class Music
    {
        class Employee
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public string Department { get; set; }

            public int Salary { get; set; }

        }

        public void ManipulateLINQ3()
        {
            IEnumerable<Employee> employees = new List<Employee>()
            {

                new Employee {Id = 5, Name="Mara", Department="Music", Salary= 70000},
                new Employee {Id = 6, Name="Micheal", Department="Music", Salary= 90000},
                new Employee {Id = 1, Name="Winner", Department="Music", Salary= 5000}

            };

            Console.WriteLine("");
            Console.WriteLine("The Music employees and their salaries are : ");
            var employeeSalaries = employees.OrderByDescending(emp => emp.Salary);
            foreach (var employeeSalary in employeeSalaries)
            {
                Console.WriteLine($"{employeeSalary.Name} : {employeeSalary.Salary}");
            }
        }
    }
}
