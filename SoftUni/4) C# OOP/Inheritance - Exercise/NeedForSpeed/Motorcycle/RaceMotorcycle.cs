using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed.Motorcycle
{
    public class RaceMotorcycle : Motorcycle
    {
        public RaceMotorcycle(int horsePower, double fuel) 
            : base(horsePower, fuel)
        {
            this.fuelConsumptions = 8;
        }
    }
}
