namespace WildFarm.Models.Animals
{
    using Foods;

    public class Dog : Mammal
    {
        private const double WEIGHT_MULTIPLIER = 0.4;

        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override double WeightMultiplier => WEIGHT_MULTIPLIER;

        public override ICollection<Type> PrefferedFoods => new List<Type>()
        { typeof(Meat)};

        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
}