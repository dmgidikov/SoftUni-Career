using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Animals.Mammal;
using WildFarm.Models.Food;

namespace WildFarm.Models.Animals.Mammal
{
    public class Mouse : Mammal
    {
        private const double WEIGHT_MULTIPLIER = 0.10;

        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {

        }

        public override double WeightMultiplier => WEIGHT_MULTIPLIER;

        public override ICollection<Type> PrefferedFoods =>
            new List<Type>() { typeof(Fruit), typeof(Vegetable) };

        public override string ProduceSound()
        {
            return $"Squeak";
        }

        public override string ToString()
        {
            return base.ToString() + $"{this.Weight}, " +
               $"{this.LivingRegion}, {this.FoodEaten:f2}]";
        }
    }
}
