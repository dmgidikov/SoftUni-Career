namespace _01_RawData
{
    public class StartUp
    {
        public static void Main()
        {
            var input = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < input; i++)
            {
                var temp = Console.ReadLine().Split();
                var tempCar = CreateCar(temp);
                cars.Add(tempCar);
            }

            var filterWord = Console.ReadLine();

            if (filterWord == "fragile")
            {
                cars = cars
               .Where(x => x.Cargo.Type == filterWord)
               .Where(y => y.Tires.Any(x => x.Pressure < 1))
               .ToList();
            }
            else if (filterWord == "flamable")
            {
                cars = cars
               .Where(x => x.Cargo.Type == filterWord)
              .Where(y => y.Engine.Power >= 250)
              .ToList();
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

        }

        private static Car CreateCar(string[] temp)
        {
            var carModel = temp[0];

            var engine = CreateEngine(temp);
            var cargo = CreateCargo(temp);
            var tires = CreateTires(temp);

            Car car = new Car(carModel, engine, cargo, tires);
            return car;
        }

        private static List<Tire> CreateTires(string[] temp)
        {
            var tires = new List<Tire>();

            for (int j = 5; j < temp.Length; j += 2)
            {
                var pressure = double.Parse(temp[j]);
                var age = int.Parse(temp[j + 1]);

                var tire = new Tire(pressure, age);

                tires.Add(tire);
            }

            return tires;
        }

        private static Cargo CreateCargo(string[] temp)
        {
            var weight = int.Parse(temp[3]);
            var type = temp[4];
            var cargo = new Cargo(weight, type);

            return cargo;
        }

        private static Engine CreateEngine(string[] temp)
        {
            var speed = int.Parse(temp[1]);
            var power = int.Parse(temp[2]);

            var engine = new Engine(speed, power);

            return engine;
        }
    }
}