using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQinCSharp
{
    internal class LearningLINQ
    {
        class Employee
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public string Department { get; set; }

            public int Salary { get; set; }

        }
        class Department
        {
            public int Id { get; set; }

            public string Name { get; set; }
        }

        public void ManipulateLINQ()
        {
            IEnumerable<Employee> employees = new List<Employee>()
            {
                new Employee {Id = 1, Name="Winner", Department="Music", Salary= 5000},
                new Employee {Id = 2, Name="Brandon", Department="Game", Salary= 4000},
                new Employee {Id = 3, Name="MaryAnn", Department="Business", Salary= 2000},
                new Employee {Id = 4, Name="Don", Department="Business", Salary= 1000000},
                new Employee {Id = 5, Name="Mara", Department="Music", Salary= 70000},
                new Employee {Id = 6, Name="Micheal", Department="Music", Salary= 90000}
            };

            var musicEmployee = employees.Where(emp => emp.Department == "Music");
            foreach(var musicemployee in musicEmployee)
            {
                Console.WriteLine(musicemployee.Name);

            }

            Console.WriteLine("The employee and their salaries are : ");
            var employeeSalaries = employees.OrderByDescending(emp => emp.Salary);
            foreach(var employeeSalary in employeeSalaries)
            {
                Console.WriteLine($"{employeeSalary.Name} : {employeeSalary.Salary}");
            }

            IEnumerable<Department> departments = new List<Department>()
            {
                new Department {Id = 1, Name="Music"},
                new Department {Id = 2, Name="Business"},
                new Department {Id = 3, Name="Game"},
            };

            var joinEmployeesAndDepartments = employees.Join(
                departments,
                emp => emp.Department,
                dept => dept.Name,
                (emp, dept) => new { emp.Name, Department = dept.Name});

            Console.WriteLine("The Join for the Employee and Departments are :");
            foreach (var joinedemployeedept in joinEmployeesAndDepartments)
            {
                Console.WriteLine($"{joinedemployeedept.Name} : {joinedemployeedept.Department}");
            }
        }
    }
}
