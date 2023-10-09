using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main()
        {
            var rotations = int.Parse(Console.ReadLine());

            var cars = new HashSet<Car>();

            for (int i = 0; i < rotations; i++)
            {
                var input = Console.ReadLine().Split();

                var model = input[0];
                var fuelAmount = double.Parse(input[1]);
                var fuelConsumptions = double.Parse(input[2]);

                var car = new Car()
                {
                    Model = model,
                    FuelAmount = fuelAmount,
                    FuelConsumption = fuelConsumptions
                };

                cars.Add(car);
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "End")
                {
                    Console.WriteLine(string.Join(Environment.NewLine, cars));
                    break;
                }

                var commands = input.Split();

                var currentCar = commands[1];
                var amountOfKm = double.Parse(commands[2]);

                var driveCar = cars.Where(x => x.Model == currentCar).ToList().First();

                driveCar.Drive(currentCar, amountOfKm);                
            }
        }
    }
}