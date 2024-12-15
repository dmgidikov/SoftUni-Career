namespace _02.SalaryIncrease
{
    public class Person
    {
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName { get; private set; }

        public string LastName{ get;  private set; }

        public int Age { get; private set; }

        public decimal Salary { get; private set; }

        public void IncreaseSalary(decimal percentage)
        {
            var filter = 1;
           
            if (this.Age < 30)
            {
                filter = 2;
            }

            this.Salary += (this.Salary * percentage / 100) / filter;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} recives {this.Salary:f2} leva.";
        }
    }
}