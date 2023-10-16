using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Child : Person
    {
        private const int CHILD_MAX_AGE = 15;
        public Child(string name, int age)
            : base(name, age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override int Age
        {
            get => base.Age;

            protected set
            {
                if (value <= CHILD_MAX_AGE)
                {
                    base.Age = value;
                }
                else
                {
                    throw new Exception("Age cannot be over 15!");
                }
            }
        }
    }
}