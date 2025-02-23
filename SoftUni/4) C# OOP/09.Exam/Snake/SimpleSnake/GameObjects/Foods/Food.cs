namespace SimpleSnake.GameObjects.Foods
{
    public abstract class Food
    {
        protected Food(string symbol, int foodPoints, Coordinate coordinate)
        {
            FoodSymbol = symbol;
            FoodPoints = foodPoints;
            FoodCoordinate = coordinate;
        }

        public string FoodSymbol { get; set; }

        public int FoodPoints { get; set; }

        public Coordinate FoodCoordinate { get; set; }
    }
}