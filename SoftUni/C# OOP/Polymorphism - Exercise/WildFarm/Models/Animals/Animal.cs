using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Common;
using WildFarm.Models.Animals.Contracts;
using WildFarm.Models.Food.Contracts;

namespace WildFarm.Models.Animals
{
    public abstract class Animal : IAnimal
    {
        private int foodEaten;

        protected Animal(string name, double weight) 
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name { get; private set; }    

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }

        public abstract double WeightMultiplier { get; }

        public abstract ICollection<Type> PrefferedFoods { get; }

        public abstract string ProduceSound();

        public void Feed(IFood food)
        {
            if (this.PrefferedFoods.Contains(food.GetType()) == false)
            {
                throw new ArgumentException(
                    string.Format(Exceptions.FOOD_EXCEPTION,
                    this.GetType().Name, food.GetType().Name));
            }

            this.Weight += this.WeightMultiplier * food.Quantity;
            this.foodEaten += food.Quantity;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, ";
        }
    }
}
