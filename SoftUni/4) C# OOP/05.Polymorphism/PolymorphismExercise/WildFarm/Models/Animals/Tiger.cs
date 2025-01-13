namespace WildFarm.Models.Animals
{
    using Foods;

    public class Tiger : Mammal
    {
        private const double WEIGHT_MULTIPLIER = 1;

        public Tiger(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override double WeightMultiplier => WEIGHT_MULTIPLIER;

        public override ICollection<Type> PrefferedFoods => new List<Type>()
        { typeof(Meat)};

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
    }
}