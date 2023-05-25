using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        private const string EXEPTION = "Invalid input!";

        private string name;
        private int age;
        private string type;

        public string sound = string.Empty;

        public Animal(string name, int age, string type) 
        {
            this.Name = name;
            this.Age = age;
            this.Type = type;
        }

        public string Name
        {
            get => this.name;
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(EXEPTION);
                }

                this.name = value;
            }
        }

        public int Age
        {
            get => this.age;
            set 
            {
                if (value < 0) 
                {
                    throw new ArgumentException(EXEPTION);
                }

                this.age = value;
            }
        }

        public string Type
        {
            get => this.type;
            set 
            {
                if (string.IsNullOrWhiteSpace(value) || value != "Male" && value != "Female")
                {
                    throw new ArgumentException(EXEPTION);
                }

                this.type = value;
            }
        }

        public virtual string ProduceSound()
        {
            return $"{sound}";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(this.GetType().Name);
            sb.AppendLine(this.Name + " " + this.Age + " " + Type);
            sb.AppendLine(this.ProduceSound());

            return sb.ToString().TrimEnd();
        }
    }
}
