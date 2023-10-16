using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Beverages.CoffeAndTea
{
    public class Coffee : HotBeverage
    {
        private const double CoffeeMililiters = 90;
        private const decimal CoffeePrice = 3.5m;

        public Coffee(string name, double caffeine)
            : base(name, CoffeePrice, CoffeeMililiters)
        {
            this.Caffeine = caffeine;
        }

        public double Caffeine { get; set; }
    }
}
