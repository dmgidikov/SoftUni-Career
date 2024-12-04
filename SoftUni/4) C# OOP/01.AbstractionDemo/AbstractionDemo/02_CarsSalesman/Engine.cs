namespace _02_CarsSalesman
{
    using System.Text;

    public class Engine
    {
        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
        }

        public string Model { get; set; }

        public int Power { get; set; }

        public int Displacement { get; set; }

        public string Efficientcy { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{Model}");
            sb.AppendLine($"    Power: {Power}");

            if (Displacement != null)
            {
                sb.AppendLine($"    Displacement: {Displacement}");
            }
            else
            {
                sb.AppendLine(@$"    Displacement: n/a");
            }

            if (Efficientcy != null)
            {
                sb.AppendLine($"    Efficientcy: {Efficientcy}");
            }
            else
            {
                sb.AppendLine(@$"    Efficientcy: n/a");
            }

            return sb.ToString().TrimEnd();
        }
    }
}