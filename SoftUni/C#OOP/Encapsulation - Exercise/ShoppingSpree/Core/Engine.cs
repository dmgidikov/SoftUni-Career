using ShoppingSpree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree.Core
{
    public class Engine
    {
        private List<Product> products;
        private List<Person> people;

        public Engine()
        {
            this.products = new List<Product>();
            this.people = new List<Person>();
        }

        public void Run()
        {
            AddPeople();
            AddProducts();


            while (true)
            {
                var command = Console.ReadLine().Split();

                if (command[0] == "END")
                {
                    break;
                }
                else
                {
                    var personName = command[0];
                    var productName = command[1];

                    try
                    {
                        var person = people.First(p => p.Name == personName);
                        var product = products.First(p => p.Name == productName);

                        person.BuyProduct(product);

                        Console.WriteLine($"{person.Name} bought {product.Name}"); 
                    }
                    catch (InvalidOperationException iox)
                    {

                        Console.WriteLine(iox.Message);
                    }
                }
            }
        }

        private void AddPeople()
        {
            var peopleArgs = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < peopleArgs.Length; i++)
            {
                var temp = peopleArgs[i].Split('=', StringSplitOptions.RemoveEmptyEntries).ToArray();

                var person = new Person(temp[0], decimal.Parse(temp[1]));

                people.Add(person);
            }
        }

        private void AddProducts()
        {
            var productArgs = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < productArgs.Length; i++)
            {
                var temp = productArgs[i].Split('=', StringSplitOptions.RemoveEmptyEntries).ToArray();

                var product = new Product(temp[0], decimal.Parse(temp[1]));

                products.Add(product);
            }
        }
    }
}
