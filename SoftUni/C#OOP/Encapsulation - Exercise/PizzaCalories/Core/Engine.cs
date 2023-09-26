using PizzaCalories.Models;
using PizzaCalories.Models.SubModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories.Core
{
    public class Engine
    {
        private const int TOPPING_MAX_VALUE = 10;

        private List<Topping> toppings;
        public Engine()
        {
            this.toppings = new List<Topping>();
        }

        public void Run()
        {
            var pizzaInput = Console.ReadLine().Split();
            var pizzaName = pizzaInput[1];

            var doughInput = Console.ReadLine().ToLower().Split();

            try
            {
                var dough = new Dough(doughInput[1], doughInput[2], double.Parse(doughInput[3]));

                while (true)
                {
                    var toppingArgs = Console.ReadLine().ToLower().Split();

                    if (toppingArgs[0] == "end")
                    {
                        var pizza = new Pizza(pizzaName, dough, toppings);

                        Console.WriteLine(pizza);
                        break;
                    }
                    else
                    {
                        if (toppings.Count > TOPPING_MAX_VALUE)
                        {
                            throw new ArgumentException(Exeptions.Exeptions.PizzaTotalToppingsExeption);
                        }

                        var topping = new Topping(toppingArgs[1], double.Parse(toppingArgs[2]));
                        toppings.Add(topping);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
