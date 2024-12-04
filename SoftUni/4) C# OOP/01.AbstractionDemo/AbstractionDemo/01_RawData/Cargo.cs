using System.Security.Cryptography.X509Certificates;

namespace _01_RawData
{
    public class Cargo
    {
        public Cargo(int weight, string type)
        {
            this.Weight = weight;
            this.Type = type;
        }

        public int Weight { get; }

        public string Type { get; }

        public override string ToString()
        {
            return $"{this.Weight} {this.Type}";
        }
    }
}