using System.Text;

namespace _01_RawData
{
    public class Car
    {
        private List<Tire> tires;

        public Car(string model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.tires = tires;
        }

        public string Model { get; private set; }

        public Engine Engine { get; private set; }

        public Cargo Cargo { get; private set; }

        public IReadOnlyCollection<Tire> Tires => this.tires;

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append($"{this.Model} {this.Engine} {this.Cargo} ");

            foreach (var tire in tires)
            {
                sb.Append(tire.ToString());
            }

            return sb.ToString();
        }
    }
}