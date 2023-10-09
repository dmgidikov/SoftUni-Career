using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Food;

namespace WildFarm.Models.Animals.Mammal.Feline
{
    public class Cat : Feline
    {
        private const double WEIGHT_MULTIPLIER = 0.30;
        public Cat(string name, 
            double weight, 
            string livingRegion, 
            string breed) 
            : base(name, weight, livingRegion, breed)
        {

        }

        public override double WeightMultiplier => WEIGHT_MULTIPLIER;

        public override ICollection<Type> PrefferedFoods =>
            new List<Type>() { typeof(Vegetable), typeof(Meat) };

        public override string ProduceSound()
        {
            return $"Meow";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
