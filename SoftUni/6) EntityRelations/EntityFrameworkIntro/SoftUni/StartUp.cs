using Microsoft.EntityFrameworkCore;
using SoftUni.Data;
using SoftUni.Models;
using System.Linq;
using System.Text;

namespace SoftUni
{
    public class StartUp
    {
        public static void Main()
        {
            var context = new SoftUniContext();

            var result = GetEmployeesByFirstNameStartingWithSa(context);

            Console.WriteLine(result);
        }

        // Problem 03.
        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            var sb = new StringBuilder();

            var result = context
                .Employees
                .OrderBy(e => e.EmployeeId)
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.MiddleName,
                    e.JobTitle,
                    e.Salary
                });

            foreach (var e in result)
            {
                sb
                    .AppendLine(string.Join(" ",
                    e.FirstName, e.LastName, e.MiddleName, e.JobTitle, $"{e.Salary:f2}"));
            }

            return sb.ToString().TrimEnd();
        }

        // Problem 04.
        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            var sb = new StringBuilder();

            var result = context
                .Employees
                .OrderBy(e => e.FirstName)
                .Select(e => new
                {
                    e.FirstName,
                    e.Salary
                })
                .Where(s => s.Salary > 50000);

            foreach (var e in result)
            {
                sb
                    .AppendLine($"{e.FirstName} - {e.Salary:f2}");
            }

            return sb.ToString().TrimEnd();
        }

        // Problem 05.
        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            var sb = new StringBuilder();

            var result = context
                .Employees
                .OrderBy(e => e.Salary)
                .ThenByDescending(e => e.FirstName)
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.Department,
                    e.Salary
                })
                .Where(e => e.Department.Name == "Research and Development");

            foreach (var e in result)
            {
                sb
                    .AppendLine($"{e.FirstName} {e.LastName} from {e.Department.Name} - {e.Salary:f2}");
            }

            return sb.ToString().TrimEnd();
        }

        // Problem 06.
        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            var newAddress = new Address()
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };

            var nakov = context
                .Employees
                .First(e => e.LastName == "Nakov");

            nakov.Address = newAddress;

            context.SaveChanges();

            var sb = new StringBuilder();

            var addressText = context
                .Employees
                .OrderByDescending(e => e.AddressId)
                .Select(e => new
                {
                    AddressText = e.Address.AddressText
                })
                .Take(10)
                .ToList();

            foreach (var a in addressText)
            {
                Console.WriteLine(a.AddressText);
            }

            return sb.ToString().TrimEnd();
        }

        //Problem 07.
        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            var startingDate = new DateTime(2001, 01, 01);
            var endDate = new DateTime(2003, 12, 31);

            var result = context
                .Employees
                .Where(e => e.Projects.Any(p => p.StartDate >= startingDate && p.EndDate <= endDate))
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    ManagerFirstName = e.Manager.FirstName,
                    ManagerLastName = e.Manager.LastName,
                    Projects = e.Projects.Select(ep => new
                    {
                        ep.Name,
                        ep.StartDate,
                        ep.EndDate
                    })
                })
                .Take(10);

            var sb = new StringBuilder();

            foreach (var e in result)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} - Manager: {e.ManagerFirstName} {e.ManagerLastName}");

                foreach (var p in e.Projects)
                {
                    var startDate = p.StartDate.ToString("M/d/yyyy h:mm:ss tt");
                    var finalDate = p.EndDate.HasValue ? p.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt") : "not finished";

                    sb.AppendLine($"--{p.Name} - {startDate} - {endDate}");
                }
            }
            return sb.ToString().TrimEnd();
        }

        //Problem 08.
        public static string GetAddressesByTown(SoftUniContext context)
        {
            var addresses = context
                .Addresses
                .OrderByDescending(a => a.Employees.Count)
                .ThenBy(a => a.Town.Name)
                .ThenBy(a => a.AddressText)
                .Select(a => new
                {
                    Employees = a.Employees.Count,
                    TownName = a.Town.Name,
                    AddressText = a.AddressText
                })
                .Take(10);

            var sb = new StringBuilder();

            foreach (var a in addresses)
            {
                sb
                    .AppendLine($"{a.AddressText}, {a.TownName}, {a.Employees} employees");
            };

            return sb.ToString().TrimEnd();
        }

        //Problem 09.
        public static string GetEmployee147(SoftUniContext context)
        {
            var e147 = context
                .Employees
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.JobTitle,
                    e.Projects,
                    e.EmployeeId
                })
                .Where(e => e.EmployeeId == 147)
                .SingleOrDefault();          
                

            var sb = new StringBuilder();

            sb.AppendLine($"{e147.FirstName}, {e147.LastName}, {e147.JobTitle}");

            foreach (var project in e147.Projects.OrderBy(x => x.Name))
            {
                sb.AppendLine(project.Name);
            }

            return sb.ToString().TrimEnd();
        }

        //Problem 10.
        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            var departments = context
                .Departments
                .Where(en => en.Employees.Count > 5)
                .OrderBy(en => en.Employees.Count)
                .ThenBy(d => d.Name)
                .Select(d => new
                {
                    DepartmentName = d.Name,
                    ManagerFirstName = d.Manager.FirstName,
                    ManagerLastName = d.Manager.LastName,
                    d.Employees
                })
                .ToList();

            var sb = new StringBuilder();

            foreach (var de in departments)
            {
                sb
                    .AppendLine($"{de.DepartmentName} - {de.ManagerFirstName} {de.ManagerLastName}");

                foreach (var e in de.Employees.OrderBy(e=>e.FirstName).ThenBy(e=> e.LastName))
                {
                    sb
                        .AppendLine($"{e.FirstName} {e.LastName} - {e.JobTitle}");
                }

                sb.AppendLine(new string('-', 10));
            }

            return sb.ToString().TrimEnd();
        }

        //Problem 11.
        public static string GetLatestProjects(SoftUniContext context)
        {
            var latestProjects = context
                .Projects
                .OrderByDescending(x => x.StartDate)
                .Take(10)
                .Select(x => new
                {
                    x.Name,
                    x.Description,
                    x.StartDate
                })
                .OrderBy(x => x.Name);

            var sb = new StringBuilder();

            foreach (var project in latestProjects)
            {
                sb
                    .AppendLine(project.Name)
                    .AppendLine(project.Description)
                    .AppendLine(project.StartDate.ToString("M/d/yyyy h:mm:ss tt"));
            }

            return sb.ToString().TrimEnd();
        }

        //Problem 12.
        public static string IncreaseSalaries(SoftUniContext context)
        {
            var specificDepartmentNames = new[]
                {"Engineering", "Tool Design", "Marketing", "Information Services"};

            var employees = context
                .Employees
                .Include(x => x.Departments)
                .Where(x => specificDepartmentNames.Contains(x.Department.Name))
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .ToList();

            var sb = new StringBuilder();

            foreach (var em in employees)
            {
                em.Salary += em.Salary * 0.12m;
            }

            foreach (var em in employees)
            {
                sb
                     .AppendLine($"{em.FirstName} {em.LastName} ({em.Salary:f2})");
            }

            return sb.ToString().TrimEnd();
        }

        //Problem 13.
        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            var employees = context
                .Employees
                .Where(x => x.FirstName.StartsWith("Sa"))
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .Select(x => new
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    JobTitle = x.JobTitle,
                    Salary = x.Salary
                })
                .ToList();

            var sb = new StringBuilder();

            foreach (var e in employees)
            {
                sb
                    .AppendLine($"{e.FirstName} {e.LastName} - {e.JobTitle} - ({e.Salary:f2})");
            }

            return sb.ToString().TrimEnd();
        }

        //Project 14.
        public static string DeleteProjectById(SoftUniContext context)
        {
            
        }

    }
}