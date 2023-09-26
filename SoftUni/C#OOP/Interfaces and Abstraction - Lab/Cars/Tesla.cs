using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Tesla : Car, IElectricCar
    {
        public Tesla(string model, string color, int battery) 
            :base(model, color) 
        {
            this.Battery = battery;
        }
        public int Battery { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{this.Color} Tesla {this.Model} with {this.Battery} Batteries");
            sb.AppendLine(Start());
            sb.AppendLine(End());

            return sb.ToString().TrimEnd();
        }
    }
}
