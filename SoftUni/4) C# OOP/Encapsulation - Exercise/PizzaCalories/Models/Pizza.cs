using PizzaCalories.Models.SubModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories.Models
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name, Dough dough, List<Topping> toppings)
        {
            this.Name = name;
            this.dough = dough;
            this.toppings = toppings;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (value.Length < Constants.Consts.PIZZA_NAME_MIN_LENGTH ||
                    value.Length > Constants.Consts.PIZZA_NAME_MAX_LENGTH)
                {
                    throw new ArgumentException(Exeptions.Exeptions.PizzaNameExeption);
                }

                this.name = value;
            }
        }

        public override string ToString()
        {
            var doughCalories = this.dough.GetCalories();
            var toppingCalories = 0d;

            foreach (var topping in toppings)
            {
                var tempCalories = topping.GetCalories();
                toppingCalories += tempCalories;
            }

            var totalCalories = doughCalories + toppingCalories;
            return $"{this.name} - {totalCalories:f2} Calories.";
        }
    }
}
