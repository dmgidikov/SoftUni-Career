using ShoppingSpree.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree.Models
{
    public class Product
    {
        private const int COST_MIN_VALUE = 0;

        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(GlobalConstants.InvalidNameMessage);
                }

                name = value;
            }
        }

        public decimal Cost
        {
            get => cost;
            private set
            {
                if (value < COST_MIN_VALUE)
                {
                    throw new ArgumentException(GlobalConstants.InvalidCostMessage);
                }

                cost = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}
