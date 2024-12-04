using System.Text;

namespace _02_CarsSalesman
{
    public class Car
    {
        public Car(string model, Engine engine) 
        {
            this.Model = model;
            this.Engine = engine;
        }

        public string Model { get; }

        public Engine Engine { get; }

        public int Weight { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{this.Model}:");
            sb.AppendLine($"  {Engine.ToString()}");

            if (Weight != 0)
            {
                sb.AppendLine($"  Weight: {this.Weight}");
            }
            else
            {
                sb.AppendLine(@$"  Weight: n/a");
            }

            if (Color != null)
            {
                sb.AppendLine($"  Color: {this.Color}");
            }
            else
            {
                sb.AppendLine(@$"  Color: n/a");
            }

            return sb.ToString().TrimEnd();
        }
    }
}