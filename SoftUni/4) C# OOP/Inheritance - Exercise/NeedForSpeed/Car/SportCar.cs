using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed.Car
{
    public class SportCar : Car
    {
        public SportCar(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
            this.fuelConsumptions = 10;
        }
    }
}
