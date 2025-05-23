﻿using System.Text;

namespace _02.AnimalFarm
{
    public class Chicken
    {
        private const int MIN_AGE = 0;
        private const int MAX_AGE = 15;

        private string _name;
        private int _age;

        internal Chicken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get => _name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }

                _name = value;
            }
        }

        public int Age
        {
            get => _age;
            private set
            {
                if (value < MIN_AGE || value > MAX_AGE)
                {
                    throw new ArgumentException("Age should be between 0 and 15.");
                }

                _age = value;
            }
        }

        public double ProductPerDay => this.CalculateProductPerDay();

        private double CalculateProductPerDay()
        {
            switch (this.Age)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    return 1.5;
                case 4:
                case 5:
                case 6:
                case 7:
                    return 2;
                case 8:
                case 9:
                case 10:
                case 11:
                    return 1;
                default:
                    return 0.75;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Chicken {_name} (age {_age}) can produce {this.ProductPerDay} eggs per day.");
            
            return sb.ToString();
        }
    }
}