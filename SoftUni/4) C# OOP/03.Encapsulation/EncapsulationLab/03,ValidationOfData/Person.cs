namespace _03_ValidationOfData
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private decimal _salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName 
        {
            get => _firstName;
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot be less than 3 symbols");
                }

                _firstName = value;
            }
        }

        public string LastName
        {
            get => _lastName;
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot be less than 3 symbols");
                }

                _lastName = value;
            }
        }
        public int Age 
        { 
            get => _age;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be 0 or less");
                }   

                _age = value;
            }
        }

        public decimal Salary
        {
            get => _salary;
            private set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva!");
                }
               
                _salary = value;
            }
        }

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