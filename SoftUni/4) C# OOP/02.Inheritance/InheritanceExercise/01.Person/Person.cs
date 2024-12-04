using System.Text;

namespace _01.Person
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; }

        public virtual int Age
        {
            get => this.age;
            protected set 
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Age cannot be 0");
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Name: {this.name}, Age: {this.age}");

            return sb.ToString().TrimEnd();
        }
    }
}