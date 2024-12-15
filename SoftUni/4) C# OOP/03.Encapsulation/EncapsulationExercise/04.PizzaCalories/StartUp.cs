namespace _04.PizzaCalories
{
    using Ingredients;

    public class StartUp
    {
        private const int TOPPING_MAX_VALUE = 10;

        public static void Main()
        {
            var pizzaName = Console.ReadLine().Split().Last();

            var doughArgs = Console.ReadLine().ToLower().Split();

            var dough = new Dough(doughArgs[1], doughArgs[2], double.Parse(doughArgs[3]));

            var toppinngs = new List<Topping>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                var toppingArgs = input.Split();

                var toppingType = toppingArgs[1];
                var toppingWeight = double.Parse(toppingArgs[2]);

                var topping = new Topping(toppingType, toppingWeight);
                toppinngs.Add(topping);  
            }

            var pizza = new Pizza(pizzaName, dough, toppinngs);
            Console.WriteLine(pizza);
        }
    }
}