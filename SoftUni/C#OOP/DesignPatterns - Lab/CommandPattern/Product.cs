using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Product
    {
        public Product(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }

        public int Price { get; set; }


        public void IncreasePrice(int amount)
        {
            this.Price += amount;
            Console.WriteLine($"The price for the {Name} has been icreased by {amount}");
        }

        public void DecreasePrice(int amount)
        {
            this.Price -= amount;
            Console.WriteLine($"The price for the {Name} has been decreased by {amount}");
        }

        public override string ToString() => $"Current price for the {Name} product is {Price}";
    }
}
