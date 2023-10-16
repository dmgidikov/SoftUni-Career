namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            var tires = new List<Tire[]>();
            var engines = new List<Engine>();
            var cars = new List<Car>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "No more tires")
                {
                    break;
                }

                var tireInfo = input.Split();

                var t1Year = int.Parse(tireInfo[0]);
                var t1Pressure = double.Parse(tireInfo[1]);
                var t2Year = int.Parse(tireInfo[2]);
                var t2Pressure = double.Parse(tireInfo[3]);
                var t3Year = int.Parse(tireInfo[4]);
                var t3Pressure = double.Parse(tireInfo[5]);
                var t4Year = int.Parse(tireInfo[6]);
                var t4Pressure = double.Parse(tireInfo[7]);

                var t1 = new Tire(t1Year, t1Pressure);
                var t2 = new Tire(t2Year, t2Pressure);
                var t3 = new Tire(t3Year, t3Pressure);
                var t4 = new Tire(t4Year, t4Pressure);

                var currentTires = new Tire[4]
                    {
                        t1, t2, t3, t4,
                    };

                tires.Add(currentTires);
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Engines done")
                {
                    break;
                }

                var engineInfo = input.Split();

                var horsePower = int.Parse(engineInfo[0]);
                var cubicCapacity = double.Parse(engineInfo[1]);

                var engine = new Engine(horsePower, cubicCapacity);
                engines.Add(engine);
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Show special")
                {
                    cars = cars
                        .Where(x => x.Year >= 2017)
                        .Where(x => x.Engine.HorsePower >= 330)
                        .ToList();


                    foreach (var c in cars)
                    {
                        double tiresSum = 0;

                        foreach (var t in c.Tires)
                        {
                            tiresSum += t.Pressure;
                        }

                        if (tiresSum > 9 && tiresSum < 10)
                        {
                            c.Drive(20);
                            Console.WriteLine(c.CarDetails());
                        }
                    }
                        
                    break;
                }

                var carInfo = input.Split();

                var make = carInfo[0];
                var model = carInfo[1];
                var year = int.Parse(carInfo[2]);
                var fuelQuantity = double.Parse(carInfo[3]);
                var fuelConsumption = double.Parse(carInfo[4]);
                var engineIndex = int.Parse(carInfo[5]);
                var tiresIndex = int.Parse(carInfo[6]);

                var car = new Car(
                    make,
                    model,
                    year,
                    fuelQuantity,
                    fuelConsumption,
                    engines[engineIndex],
                    tires[tiresIndex]);

                cars.Add(car);
            }
        }
    }
}