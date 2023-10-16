using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Common;
using WildFarm.Core.Contracts;
using WildFarm.Models.Animals;
using WildFarm.Models.Animals.Birds;
using WildFarm.Models.Animals.Contracts;
using WildFarm.Models.Animals.Mammal;
using WildFarm.Models.Animals.Mammal.Feline;
using WildFarm.Models.Food;
using WildFarm.Models.Food.Contracts;

namespace WildFarm.Core
{
    public class Engine : IEngine
    {
        private ICollection<IAnimal> animals;

        public Engine()
        {
            this.animals = new List<IAnimal>();
        }

        public void Run()
        {
            while (true)
            {
                var command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                var animalArgs = command.Split();
                var foodArgs = Console.ReadLine().Split();

                IAnimal animal = ProduceAnimal(animalArgs);
                IFood food = ProduceFood(foodArgs);

                animals.Add(animal);
                Console.WriteLine(animal.ProduceSound());

                try
                {
                    animal.Feed(food);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static IFood ProduceFood(string[] foodArgs)
        {
            IFood food = null;

            var foodType = foodArgs[0];
            var foodQuantity = int.Parse(foodArgs[1]);

            if (foodType == "Vegetable")
            {
                food = new Vegetable(foodQuantity);
            }
            else if (foodType == "Fruit")
            {
                food = new Fruit(foodQuantity);
            }
            else if (foodType == "Meat")
            {
                food = new Meat(foodQuantity);
            }
            else if (foodType == "Seeds")
            {
                food = new Seeds(foodQuantity);
            }

            return food;
        }

        private static IAnimal ProduceAnimal(string[] animalArgs)
        {
            IAnimal animal = null;

            var animalType = animalArgs[0];
            var animalName = animalArgs[1];
            var animalWeight = double.Parse(animalArgs[2]);

            if (animalType == "Owl")
            {
                var wingSize = double.Parse(animalArgs[3]);

                animal = new Owl(animalName, animalWeight, wingSize);
            }
            else if (animalType == "Hen")
            {
                var wingSize = double.Parse(animalArgs[3]);

                animal = new Hen(animalName, animalWeight, wingSize);
            }
            else
            {
                var livingRegion = animalArgs[3];

                if (animalType == "Mouse")
                {
                    animal = new Mouse(animalName, animalWeight, livingRegion);
                }
                else if (animalType == "Dog")
                {
                    animal = new Dog(animalName, animalWeight, livingRegion);
                }
                else
                {
                    var breed = animalArgs[4];

                    if (animalType == "Cat")
                    {
                        animal = new Cat(animalName, animalWeight, livingRegion, breed);
                    }

                    else if (animalType == "Tiger")
                    {
                        animal = new Tiger(animalName, animalWeight, livingRegion, breed);
                    }
                }
            }

            return animal;
        }
    }
}
