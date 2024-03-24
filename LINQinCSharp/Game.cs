using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQinCSharp
{
    internal class Game
    {
        class Employee
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public string Department { get; set; }

            public int Salary { get; set; }

        }

        public void ManipulateLINQ2()
        {
            IEnumerable<Employee> employees = new List<Employee>()
            {

                new Employee {Id = 1, Name="Brandon", Department="Game", Salary= 4000000},
                new Employee {Id = 2, Name="Zeketo", Department="Game", Salary= 7000000},
                new Employee {Id = 3, Name="Ikechukwu", Department="Game", Salary= 5000000}

            };

            Console.WriteLine("");
            Console.WriteLine("The Game employees and their salaries are : ");
            var employeeSalaries = employees.OrderByDescending(emp => emp.Salary);
            foreach (var employeeSalary in employeeSalaries)
            {
                Console.WriteLine($"{employeeSalary.Name} : {employeeSalary.Salary}");
            }
        }
    }
}
