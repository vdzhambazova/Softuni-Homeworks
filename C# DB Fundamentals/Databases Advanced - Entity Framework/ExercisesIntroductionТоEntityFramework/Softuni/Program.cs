using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Softuni.Models;

namespace Softuni
{
    class Program
    {
        static void Main(string[] args)
        {
            SoftuniContext softuniContext = new SoftuniContext();

            using (softuniContext)
            {
                #region //P03. Employees full information         
            //var employees = softuniContext.Employees;
            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.MiddleName} {employee.JobTitle} {employee.Salary}");
            //}
                #endregion

                #region //P04. Employees with Salary Over 50 000
            //var employeesNames = softuniContext.Employees
            //                            .Where(x => x.Salary > 50000)
            //                            .Select(em => em.FirstName);
            //
            //foreach (string employeeName in employeesNames)
            //{
            //    Console.WriteLine(employeeName);
            //}
                #endregion

                #region//P05. Employees from Seattle                
            //var employees =
            //    softuniContext.Employees
            //        .Where(employee => employee.Department.Name == "Research and Development")
            //        .OrderBy(employee => employee.Salary)
            //        .ThenByDescending(employee => employee.FirstName);
            //
            //foreach (var employee in employees)
            //{
            //    Console.WriteLine($"{employee.FirstName} {employee.LastName} " +
            //                      $"from {employee.Department.Name} - ${employee.Salary:F2}");
            //}
                #endregion

                #region//P06. Adding a New Address and Updating Employee

            //var address = new Address();
            //address.AddressText = "Vitoshka 15";
            //address.TownID = 4;

            //Employee employee = softuniContext.Employees.FirstOrDefault(x => x.LastName == "Nakov");
            //employee.Address = address;
            //softuniContext.SaveChanges();

            //var employees = softuniContext.Employees
            //    .OrderByDescending(x => x.AddressID)
            //    .Select(x=>x.Address.AddressText)
            //    .Take(10);

            //foreach (var employee1 in employees)
            //{
            //    Console.WriteLine(employee1);
            //}
                #endregion

                #region//P07. Delete Project by Id

            //var projectToDelete = softuniContext.Projects.Find(2);
            //var employeesToDelete = projectToDelete.Employees;

            //foreach (var employee in employeesToDelete)
            //{
            //    employee.Projects.Remove(projectToDelete);
            //}

            //softuniContext.SaveChanges();

            //softuniContext.Projects.Remove(projectToDelete);
            //softuniContext.SaveChanges();

            //var projects = softuniContext.Projects.Select(p => p.Name).Take(10);

            //foreach (var project in projects)
            //{
            //    Console.WriteLine(project);
            //}
                #endregion

                #region //P08. Find employees in period

            //var employees = softuniContext.Employees
            //    .Where(e => e.Projects
            //        .Count(p => p.StartDate.Year >= 2001 && p.StartDate.Year <= 2003) > 0).Take(30);

            //foreach (var employee in employees)
            //{
            //    Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.Manager.FirstName}");
            //    foreach (var project in employee.Projects)
            //    {
            //        Console.WriteLine($"--{project.Name} {project.StartDate} {project.EndDate}"); 
            //    }
            //}

                #endregion

                #region//P09. Addresses by town name

            //var addresses = softuniContext.Addresses
            //    .OrderByDescending(a => a.Employees.Count)
            //    .ThenBy(a => a.Town.Name)
            //    .Take(10);

            //foreach (var address in addresses)
            //{
            //    Console.WriteLine($"{address.AddressText}, {address.Town.Name} - {address.Employees.Count} employees");
            //}

                #endregion

                #region//P10. Employee with id 147 sorted by project names 

            //Employee employee147 = softuniContext.Employees.Find(147);

            //Console.WriteLine($"{employee147.FirstName} {employee147.LastName} {employee147.JobTitle}");

            //var employee147Projects = employee147.Projects.OrderBy(p => p.Name);
            //foreach (var employee147Project in employee147Projects)
            //{
            //    Console.WriteLine(employee147Project.Name);
            //}

                #endregion

                #region//P11. Departments with more than 5 employees

            //var departaments =
            //    softuniContext.Departments
            //    .Where(d => d.Employees.Count > 5)
            //    .OrderBy(d => d.Employees.Count);

            //foreach (var departament in departaments)
            //{
            //    Console.WriteLine($"{departament.Name} {departament.Employee.FirstName}");

            //    foreach (var employee in departament.Employees)
            //    {
            //        Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.JobTitle}");
            //    }
            //}

                #endregion

                #region//P15. Find Latest 10 Projects

            //var latestProjects =
            //    softuniContext.Projects
            //        .OrderByDescending(p => p.StartDate)
            //        .Take(10)
            //        .OrderBy(p => p.Name);

            //foreach (var project in latestProjects)
            //{
            //    Console.WriteLine($"{project.Name} {project.Description} {project.StartDate} {project.EndDate}");
            //}

                #endregion

                #region//P16. Increase Salaries

            //var employeesWithRaise = softuniContext.Employees
            //    .Where(e => e.Department.Name.Equals("Engineering") || e.Department.Name.Equals("Tool Design")
            //                || e.Department.Name.Equals("Marketing") ||
            //                e.Department.Name.Equals("Information Services"));


            //foreach (var employee in employeesWithRaise)
            //{
            //    employee.Salary *= (decimal) 1.12;
            //    Console.WriteLine($"{employee.FirstName} {employee.LastName} (${employee.Salary})");
            //}

            //softuniContext.SaveChanges();

                #endregion

                #region//P17. Remove Towns

                //string townName = Console.ReadLine();
                //Town wantedTown = softuniContext.Towns.FirstOrDefault(town => town.Name == townName);
                //Address[] townAddresses = wantedTown.Addresses.ToArray();
                //foreach (Address townAddress in townAddresses)
                //{
                //    Employee[] employeesAddresses = townAddress.Employees.ToArray();
                //    foreach (var employee in employeesAddresses)
                //    {
                //        employee.AddressID = null;
                //    }
                //}

                //softuniContext.Addresses.RemoveRange(townAddresses);
                //softuniContext.Towns.Remove(wantedTown);
                //softuniContext.SaveChanges();
                //Console.WriteLine($"{townAddresses.Length} address in {townName} was deleted");

                #endregion

                #region//P18. Find Employees by First Name starting with ‘SA’

                string pattern = "SA";

                var wantedEmployees = softuniContext.Employees
                    .Where(e => e.FirstName.StartsWith(pattern));

                foreach (var wantedEmployee in wantedEmployees)
                {
                    Console.WriteLine($"{wantedEmployee.FirstName} {wantedEmployee.LastName}" +
                                      $" - {wantedEmployee.JobTitle} - (${wantedEmployee.Salary})");
                }

                #endregion
            }
        }
    }
}
