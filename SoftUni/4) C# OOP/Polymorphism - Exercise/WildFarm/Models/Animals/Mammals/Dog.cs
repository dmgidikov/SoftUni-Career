﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Food;

namespace WildFarm.Models.Animals.Mammal
{
    public class Dog : Mammal
    {
        private const double WEIGHT_MULTIPLIER = 0.40;
        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {

        }

        public override double WeightMultiplier => WEIGHT_MULTIPLIER;

        public override ICollection<Type> PrefferedFoods =>
            new List<Type>() { typeof(Meat) };

        public override string ProduceSound()
        {
            return $"Woof!";
        }

        public override string ToString()
        {
            return base.ToString() + $"{this.Weight}, " +
               $"{this.LivingRegion}, {this.FoodEaten:f2}]";
        }
    }
}
