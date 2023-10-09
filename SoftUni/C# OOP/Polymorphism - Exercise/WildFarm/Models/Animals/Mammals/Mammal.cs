namespace WildFarm.Models.Animals.Mammal
{
    public abstract class Mammal : Animal
    {
        private int foodEaten;

        public Mammal(string name, double weight, string livingRegion)
            : base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion { get; private set; }

        public override string ToString()
        {
            return base.ToString() + $"{this.Weight}, " +
                $"{this.LivingRegion}, {this.FoodEaten:f2}]";
        }
    }
}
