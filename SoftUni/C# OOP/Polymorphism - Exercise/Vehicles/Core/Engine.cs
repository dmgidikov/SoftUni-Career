using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Core.Contract;
using Vehicles.Models;

namespace Vehicles.Core
{
    public class Engine : IEngine
    {
        private Vehicle car;

        public Engine()
        {

        }

        public void Run()
        {
            var carArgs = Console.ReadLine().Split();
            var truckArgs = Console.ReadLine().Split();

            var car = new Car(double.Parse(carArgs[1]), double.Parse(carArgs[2]));
            var truck = new Truck(double.Parse(truckArgs[1]), double.Parse(truckArgs[2]));

            var rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                var commandArgs = Console.ReadLine().Split();

                try
                {
                    ProccessCommand(car, truck, commandArgs);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void ProccessCommand(Car car, Truck truck, string[] commandArgs)
        {
            var command = commandArgs[0];
            var vehicleType = commandArgs[1];

            if (command == "Drive")
            {
                var distance = double.Parse(commandArgs[2]);

                if (vehicleType == "Car")
                {
                    car.Drive(distance);
                }
                else if (vehicleType == "Truck")
                {
                    truck.Drive(distance);
                }
            }
            else if (command == "Refuel")
            {
                var amount = double.Parse(commandArgs[2]);

                if (vehicleType == "Car")
                {
                    car.Refuel(amount);
                }
                else if (vehicleType == "Truck")
                {
                    truck.Refuel(amount);
                }
            }
        }
    }
}
