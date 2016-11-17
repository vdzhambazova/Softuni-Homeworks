using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;

namespace P04CompanyRoster
{
    public class Program
    {
        public class Employee
        {
            //name, salary, position, department, email and age
            public string name;
            public decimal salary;
            public string position;
            public string departament;
            public string email;
            public int age;

            public Employee(string name, decimal salary, string position, string departament, string email = "n/a", int age = -1)
            {
                this.name = name;
                this.salary = salary;
                this.position = position;
                this.departament = departament;
                this.email = email;
                this.age = age;
            }
        }

        public static void Main(string[] args)
        {
            int numOfInput = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < numOfInput; i++)
            {
                string[] inputArgs = Console.ReadLine().Split();
                string name = inputArgs[0];
                decimal salary = decimal.Parse(inputArgs[1]);
                string position = inputArgs[2];
                string departament = inputArgs[3];

                Employee employee = new Employee(name, salary, position, departament);

                if (inputArgs.Length == 5)
                {
                    var ageOrEmail = inputArgs[4];
                    if (ageOrEmail.IndexOf("@") > 0)
                    {
                        employee.email = ageOrEmail;
                    }
                    else
                    {
                        employee.age = int.Parse(ageOrEmail);
                    }
                }

                if (inputArgs.Length == 6)
                {
                    employee.email = inputArgs[4];
                    employee.age = int.Parse(inputArgs[5]);
                }

                employees.Add(employee);
            }

            var result = employees
                .GroupBy(e => e.departament)
                .Select(e => new
                {
                    Departament = e.Key,
                    AverageSalary = e.Average(emp => emp.salary),
                    Employees = e.OrderByDescending(emp => emp.salary)
                })
                .OrderByDescending(e => e.AverageSalary)
                .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {result.Departament}");
            foreach (var employee in result.Employees)
            {
                Console.WriteLine($"{employee.name} {employee.salary:F2} {employee.email} {employee.age}");
            }
        }
    }
}
