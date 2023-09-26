namespace WildFarm.Models.Animals.Mammal.Feline
{
    public abstract class Feline : Mammal
    {
        private int foodEaten;

        protected Feline(string name, 
            double weight,
            string livingRegion, 
            string breed) 
            : base(name, weight, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed { get; protected set; }

        public override string ToString()
        {
            return base.ToString() + $" {this.Breed}, " +
                $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
