namespace DBIntro
{
    using Data;
    using DBIntro.Models;
    using System.Text;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var context = new SoftUniContext();

            Console.WriteLine(DeleteProjectById(context));
        }

        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            var allEmployees = context
                .Employees
                .OrderBy(x => x.EmployeeId)
                .Select(x => new
                {
                    id = x.EmployeeId,
                    Name = string.Join(" ", x.FirstName, x.LastName, x.MiddleName),
                    JobTitle = x.JobTitle,
                    Salary = x.Salary
                });

            var result = new StringBuilder();

            foreach (var e in allEmployees)
            {
                result
                    .AppendLine($"{e.Name} {e.JobTitle} {e.Salary:f2}");
            }

            return result.ToString().TrimEnd();
        }

        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            var result = new StringBuilder();

            var employees = context
                .Employees
                .Where(x => x.Salary > 50000)
                .OrderBy(x => x.FirstName)
                .Select(x => new
                {
                    firstName = x.FirstName,
                    salary = x.Salary
                });

            foreach (var emp in employees)
            {
                result.AppendLine($"{emp.firstName} - {emp.salary:f2}");
            }

            return result.ToString().TrimEnd();
        }

        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            var result = new StringBuilder();

            var employees = context
                .Employees
                .Where(x => x.Department.Name == "Research and Development")
                .OrderBy(x => x.Salary)
                .ThenByDescending(x => x.FirstName)
                .Select(x => new
                {
                    firstName = x.FirstName,
                    lastName = x.LastName,
                    depatmentName = x.Department.Name,
                    salary = x.Salary
                });

            foreach (var emp in employees)
            {
                result.AppendLine($"{emp.firstName} {emp.lastName} from {emp.depatmentName} - {emp.salary:f2}");
            }

            return result.ToString().TrimEnd();
        }

        // how to restore older db after db.saveChanges
        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            var result = new StringBuilder();

            var newAddress = new Address
            {
                TownId = 4,
                AddressText = "Vitoshka 15"
            };

            var nakovEmployee = context.Employees
                .Where(x => x.LastName == "Nakov")
                .FirstOrDefault();

            nakovEmployee.Address = newAddress;

            context.SaveChanges();

            var employees = context
                .Employees
                .OrderByDescending(x => x.AddressId)
                .Take(10)
                .Select(x => new
                {
                    addressText = x.Address.AddressText
                });

            foreach (var emp in employees)
            {
                result.AppendLine(emp.addressText);
            }

            return result.ToString().TrimEnd();
        }

        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            var result = new StringBuilder();

            var employees = context.Employees
                .Where(x => x.Projects.Any(x => x.StartDate.Year >= 2001 && x.StartDate.Year <= 2003))
                .Take(10)
                .Select(x => new
                {
                    PersonName = String.Join(" ", x.FirstName, x.LastName),
                    ManagerName = String.Join(" ", x.Manager.FirstName, x.Manager.LastName),
                    Projects = x.Projects
                        .Select(x => new
                        {
                            x.Name,
                            x.StartDate,
                            x.EndDate
                        })
                })
                .ToList();

            foreach (var emp in employees)
            {
                result.AppendLine($"{emp.PersonName} - Manager: {emp.ManagerName}");

                foreach (var p in emp.Projects)
                {
                    if (p.EndDate == null)
                    {
                        var endDate = p.EndDate == null ? "not finished" : $"{p.EndDate:M/d/yyyy h:mm:ss tt}";

                        result.AppendLine($"--{p.Name} - {p.StartDate:M/d/yyyy h:mm:ss tt} - {endDate}");
                    }
                }
            }

            return result.ToString().TrimEnd();
        }

        public static string GetAddressesByTown(SoftUniContext context)
        {
            var result = new StringBuilder();

            var addresses = context.Addresses
                .OrderByDescending(x => x.Employees.Count)
                .ThenBy(x => x.Town.Name)
                .ThenBy(x => x.AddressText)
                .Take(10)
                .Select(x => new
                {
                    AddressText = x.AddressText,
                    TownName = x.Town.Name,
                    EmployeeCount = x.Employees.Count
                })
                .ToList();

            foreach (var a in addresses)
            {
                result.AppendLine($"{a.AddressText}, {a.TownName} - {a.EmployeeCount} employees");
            }

            return result.ToString().TrimEnd();
        }

        public static string GetEmployee147(SoftUniContext context)
        {
            var result = new StringBuilder();

            var employee147 = context.Employees
                .Where(x => x.EmployeeId == 147)
                .Select(x => new
                {
                    EmployeeName = string.Join(" ", x.FirstName, x.LastName),
                    JobTitle = x.JobTitle,
                    Projects = x.Projects
                        .OrderBy(x => x.Name)
                        .Select(x => new
                        {
                            ProjectName = x.Name
                        })
                })
                .ToList();

            foreach (var e in employee147)
            {
                result.AppendLine($"{e.EmployeeName} - {e.JobTitle}");

                foreach (var p in e.Projects)
                {
                    result.AppendLine($"{p.ProjectName}");
                }
            }

            return result.ToString().TrimEnd();
        }

        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            var result = new StringBuilder();

            var departments = context.Departments
                .Where(x => x.Employees.Count > 5)
                .OrderBy(x => x.Employees.Count)
                .ThenBy(x => x.Name)
                .Select(x => new
                {
                    DepartmentName = x.Name,
                    ManagerName = string.Join(" ", x.Manager.FirstName, x.Manager.LastName),
                    Employees = x.Employees
                        .OrderBy(x => x.FirstName)
                        .ThenBy(x => x.LastName)
                        .Select(x => new
                        {
                            EmployeeName = string.Join(" ", x.FirstName, x.LastName),
                            JobTitle = x.JobTitle
                        })
                })
                .ToList();

            foreach (var dep in departments)
            {
                result.AppendLine($"{dep.DepartmentName} - {dep.ManagerName}");

                foreach (var emp in dep.Employees)
                {
                    result.AppendLine($"{emp.EmployeeName} - {emp.JobTitle}");
                }
            }

            return result.ToString().TrimEnd();
        }

        public static string GetLatestProjects(SoftUniContext context)
        {
            var result = new StringBuilder();

            var projects = context.Projects
                .OrderByDescending(x => x.StartDate)
                .Take(10)
                .OrderBy(x => x.Name)
                .Select(x => new
                {
                    ProjectName = x.Name,
                    Description = x.Description,
                    StartDate = x.StartDate
                })
                .ToList();

            foreach (var p in projects)
            {
                result.AppendLine(p.ProjectName);
                result.AppendLine(p.Description);
                result.AppendLine($"{p.StartDate:M/d/yyyy h:mm:ss tt}");
            }

            return result.ToString().TrimEnd();
        }

        public static string IncreaseSalaries(SoftUniContext context)
        {
            var result = new StringBuilder();

            var employeesBeforeSalaryIncrease = context.Employees
              .Where(x => x.Department.Name.Equals("Engineering")
              || x.Department.Name.Equals("Tool Design")
              || x.Department.Name.Equals("Marketing")
              || x.Department.Name.Equals("Information Services"))
              .ToList();

            foreach (var emp in employeesBeforeSalaryIncrease)
            {
                emp.Salary *= 1.12M;
            }

            var employeesAfterSalaryIncrease = employeesBeforeSalaryIncrease
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .Select(x => new
                {
                    Name = string.Join(" ", x.FirstName, x.LastName),
                    Salary = x.Salary
                });

            foreach (var e in employeesAfterSalaryIncrease)
            {
                result.AppendLine($"{e.Name} (${e.Salary:f2})");
            }

            return result.ToString().TrimEnd();
        }

        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            var result = new StringBuilder();

            var employees = context.Employees
                .Where(x => x.FirstName.StartsWith("Sa"))
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .Select(x => new
                {
                    Name = string.Join(" ", x.FirstName, x.LastName),
                    Salary = x.Salary,
                    JobTitle = x.JobTitle
                })
                .ToList();

            foreach (var emp in employees)
            {
                result.AppendLine($"{emp.Name} - {emp.JobTitle} - (${emp.Salary:f2})");
            }

            return result.ToString().TrimEnd();
        }

        public static string DeleteProjectById(SoftUniContext context)
        {
            var result = new StringBuilder();

            var projects = context.Projects
                .Take(10)
                .Select(x => x.Name)
                .ToList();

            projects.RemoveAt(1);

            foreach (var p in projects)
            {
                result.AppendLine(p);
            }

            return result.ToString().TrimEnd();
        }
    }
}