using AutoMapper;

namespace AutoMapperDemo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            
            var emp = new Employee()
            {
                Name = "Test",
                Salary = 200,
                Address = "London Baby",
                Department = "IT"
            };

            var mapper = MapperConfig.InitializeAutomapper();


            var empDTO1 = mapper.Map<EmployeeDTO>(emp);
           
            var empDTO2 = mapper.Map<Employee, EmployeeDTO>(emp);

            Console.WriteLine("Name: " + empDTO1.FullName + ", Salary: " + empDTO1.Salary + ", Address: " + empDTO1.Address + ", Department: " + empDTO1.Dept);
            Console.ReadLine();
        }
    }
}
