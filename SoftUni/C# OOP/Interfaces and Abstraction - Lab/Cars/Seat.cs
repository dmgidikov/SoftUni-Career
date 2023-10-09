using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Seat : Car
    {
        public Seat(string model, string color)
            : base(model, color)
        {

        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{this.Color} Seat {this.Model}");
            sb.AppendLine(Start());
            sb.AppendLine(End());

            return sb.ToString().TrimEnd();
        }
    }
}
