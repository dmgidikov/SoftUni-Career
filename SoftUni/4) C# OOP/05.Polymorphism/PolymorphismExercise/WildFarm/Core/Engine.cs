namespace WildFarm.Core
{
    using Factories;
    using Contracts;
    using Exceptions;
    using Models.Foods;
    using Models.Animals;
    using Models.Foods.Contracts;
    using Models.Animals.Contracts;

    public class Engine : IEngine
    {
        private ICollection<IAnimal> _animals;
        private FoodFactory _foodFactory;

        public Engine()
        {
            _animals = new List<IAnimal>();
            _foodFactory = new FoodFactory();
        }

        public void Run()
        {
            int counter = 0;

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                var args = input.Split();

                IAnimal animal = null;
                
                if (counter % 2 == 0)
                {
                    animal = args[0] switch
                    {
                        "Owl" => CreateOwl(args),
                        "Hen" => CreateHen(args),
                        "Mouse" => CreateMouse(args),
                        "Dog" => CreateDog(args),
                        "Cat" => CreateCat(args),
                        "Tiger" => CreateTiger(args),
                    };

                    _animals.Add(animal);
                }
                else
                {
                    var food = _foodFactory.ProduceFood(args[0], int.Parse(args[1]));

                    Console.WriteLine(animal.ProduceSound());

                    try
                    {
                        animal.Feed(food);
                    }
                    catch (WrongFoodException wfe)
                    {
                        Console.WriteLine(wfe.Message);
                    }
                }
            }

            foreach (var animal in _animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static Tiger CreateTiger(string[] args)
        {
            return new Tiger(args[1], double.Parse(args[2]), args[3]);
        }

        private static Cat CreateCat(string[] args)
        {
            return new Cat(args[1], double.Parse(args[2]), args[3], args[4]);
        }

        private static Mouse CreateMouse(string[] args)
        {
            return new Mouse(args[1], double.Parse(args[2]), args[3]);
        }

        private static Dog CreateDog(string[] args)
        {
            return new Dog(args[1], double.Parse(args[2]), args[3]);
        }

        private static Hen CreateHen(string[] args)
        {
            return new Hen(args[1], double.Parse(args[2]), double.Parse(args[3]));
        }

        private static Owl CreateOwl(string[] args)
        {
            return new Owl(args[1], double.Parse(args[2]), double.Parse(args[3]));
        }
    }
}