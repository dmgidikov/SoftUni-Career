using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Beverages.CoffeAndTea
{
    public class Tea : HotBeverage
    {
        public Tea(string name, decimal price, double mililiters)
            : base(name, price, mililiters)
        {

        }
    }
}
