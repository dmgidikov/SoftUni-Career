using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories.Models.SubModels
{
    public class Topping
    {
        private string type;
        private double weight;
        private List<string> possibleToppings = new List<string>
        { "meat" , "veggies" , "cheese" , "sauce"  };

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
            this.GetCalories();
        }

        public string Type
        {
            get => this.type;
            private set
            {
                if (possibleToppings.Contains(value) == false)
                {
                    throw new ArgumentException(string.Format
                        (Exeptions.Exeptions.ToppingInproperTypeExeption, value));
                }

                this.type = value;
            }
        }

        public double Weight
        {
            get => this.weight;
            private set
            {
                if (value < Constants.Consts.WEIGHT_MIN_VALUE ||
                    value > Constants.Consts.TOPPING_WEIGHT_MAX_VALUE)
                {
                    throw new ArgumentException(string.Format
                        (Exeptions.Exeptions.ToppingWeightExeption, this.Type));
                }

                this.weight = value;
            }
        }

        public double GetCalories()
        {
            var calories = 1d;

            switch (this.Type)
            {
                case "meat": calories *= 1.2; break;
                case "veggies": calories *= 0.8; break;
                case "cheese": calories *= 1.1; break;
                case "sauce": calories *= 0.9; break;
            }

            var result = 2 * this.weight * calories;

            return result;
        }
    }
}
