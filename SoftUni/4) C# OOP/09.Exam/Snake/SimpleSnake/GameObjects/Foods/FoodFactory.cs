namespace SimpleSnake.GameObjects.Foods
{
    using System;
    using System.Linq;
    using System.Reflection;

    public static class FoodFactory
    {
        public static Food GenerateRandomFood(int boardWidth, int boardHight)
        {
            var assembly = Assembly.GetCallingAssembly();

            var types = assembly
                .GetTypes()
                .Where(x => x.IsSubclassOf(typeof(Food)))
                .ToList();

            var rnd = new Random();

            var foodType = types[rnd.Next(0, types.Count)];

            var x = rnd.Next(1, boardWidth - 1);
            var y = rnd.Next(1, boardHight - 1);

            var coordinate = new Coordinate(x, y);

            return Activator.CreateInstance(foodType, coordinate) as Food;
        }
    }
}