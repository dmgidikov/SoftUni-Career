namespace Vehicles.Core
{
    using Models;
    using Contracts;

    public class Engine : IEngine
    {
        public Engine()
        {

        }

        public void Run()
        {
            var car = GetCar();

            var truck = GetTruck();

            var rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                var input = Console.ReadLine().Split();

                try
                {
                    ProcessCommand(car, truck, input);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }               
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }

        private static void ProcessCommand(Car car, Truck truck, string[] input)
        {
            if (input[0] == "Drive")
            {

                if (input[1] == "Car")
                {                    
                    Console.WriteLine(car.Drive(double.Parse(input[2])));
                }
                else if (input[1] == "Truck")
                {
                    Console.WriteLine(truck.Drive(double.Parse(input[2])));                    
                }

            }
            else if (input[0] == "Refuel")
            {
                if (input[1] == "Car")
                {
                    car.Refuel(double.Parse(input[2]));
                }
                else if (input[1] == "Truck")
                {
                    truck.Refuel(double.Parse(input[2]));
                }
            }
        }

        private static Truck GetTruck()
        {
            var truckArgs = Console.ReadLine().Split();

            var truckFuelQuantity = double.Parse(truckArgs[1]);
            var truckFuelConsumption = double.Parse(truckArgs[2]);

            var truck = new Truck(truckFuelQuantity, truckFuelConsumption);
            return truck;
        }

        private static Car GetCar()
        {
            var carArgs = Console.ReadLine().Split().ToArray();
            var carFuelQuantity = double.Parse(carArgs[1]);
            var carFuelConsumption = double.Parse(carArgs[2]);

            var car = new Car(carFuelQuantity, carFuelConsumption);
            return car;
        }
    }
}