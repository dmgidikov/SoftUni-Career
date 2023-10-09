using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        private const int PERSON_MIN_AGE = 0;

        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public virtual int Age
        {
            get => this.age;
            protected set
            {
                if (value > PERSON_MIN_AGE)
                {
                    this.age = value;
                }
                else
                {
                    throw new Exception("Age cannot be negative number!");
                }
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append($"Name: {this.Name}, Age: {this.Age}");

            return sb.ToString();
        }
    }
}
