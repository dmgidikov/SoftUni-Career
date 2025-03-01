﻿namespace _01.Person
{
    public class Child : Person
    {
        private const int CHILD_MAX_AGE = 15;

        public Child(string name, int age) 
            : base(name, age)
        {

        }

        public override int Age
        {
            get => base.Age;
            protected set
            {
                if (base.Age <= CHILD_MAX_AGE)
                {
                    base.Age = value;
                }
            }
        }
    }
}