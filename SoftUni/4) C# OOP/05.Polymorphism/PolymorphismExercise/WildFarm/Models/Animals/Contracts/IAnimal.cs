namespace WildFarm.Models.Animals.Contracts
{
    using Foods.Contracts;

    public interface IAnimal
    {
        string Name { get; }

        double Weight { get; }

        int FoodEatern { get; }

        string ProduceSound();

        void Feed(IFood food);
    }
}