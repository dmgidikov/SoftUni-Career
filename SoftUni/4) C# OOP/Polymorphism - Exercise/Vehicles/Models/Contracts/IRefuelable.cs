using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models.Contracts
{
    public interface IRefuelable
    {
        void Refuel(double fuelAmount);
    }
}
