using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Engine
    {
        private readonly List<Animal> animals;
        private const string END_OF_INPUT_COMMAND = "Beast!";

        public Engine()
        {
            this.animals = new List<Animal>();
        }

        public void Run()
        {
            while (true)
            {
                var type = Console.ReadLine();

                if (type != END_OF_INPUT_COMMAND)
                {
                    var animalArgs = Console.ReadLine().Split();

                    Animal animal;

                    try
                    {
                        animal = GetAnimal(type, animalArgs);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        continue;
                    }

                    animals.Add(animal);
                }
                else
                {
                    foreach (var animal in animals)
                    {
                        Console.WriteLine(animal);
                    }
                    break;
                }
            }
        }

        private Animal GetAnimal(string type, string[] animalArgs)
        {
            Animal animal = null;
            var name = animalArgs[0];
            var age = int.Parse(animalArgs[1]);

            if (type == "Dog")
            {
                animal = new Dog(name, age, animalArgs[2]);
            }
            else if (type == "Cat")
            {
                animal = new Cat(name, age, animalArgs[2]);
            }
            else if (type == "Frog")
            {
                animal = new Frog(name, age, animalArgs[2]);
            }
            else if (type == "Kittens")
            {
                animal = new Kitten(name, age);
            }
            else if (type == "Tomcat")
            {
                animal = new Tomcat(name, age);
            }

            return animal;
        }
    }
}
