namespace RawData
{
    public class StartUp
    {
        static void Main()
        {
            var rotations = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < rotations; i++)
            {
                var input = Console.ReadLine().Split();

                var model = input[0];

                var engineSpeed = int.Parse(input[1]);
                var enginePower = int.Parse(input[2]);

                var cargoWeingt = int.Parse(input[3]);
                var cargoType = input[4];

                var engine = GetNewEngine(engineSpeed, enginePower);
                var cargo = GetNewCargo(cargoType, cargoWeingt);
                var tires = new List<Tire>();
                GetNewTires(input, tires);

                var car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            var type = Console.ReadLine();

            if (type == "fragile")
            {
                cars = cars
                    .Where(c => c.Cargo.Type == "fragile")
                    .Where(x => x.Tires.Any(x => x.Pressure < 1))
                    .ToList();

            }
            else if (type == "flammable")
            {
                cars = cars
                    .Where(c => c.Cargo.Type == "flammable")
                    .Where(x => x.Engine.Power > 250)
                    .ToList();
            }

            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }


        static Engine GetNewEngine(int speed, int power)
        {
            return new Engine(speed, power);
        }

        static Cargo GetNewCargo(string type, int weight)
        {
            return new Cargo(type, weight);
        }

        static Tire GetNewTire(int age, double pressure)
        {
            return new Tire(age, pressure);
        }
        static void GetNewTires(string[] input, List<Tire> tires)
        {
            for (int j = 5; j < input.Length; j += 2)
            {
                var pressure = double.Parse(input[5]);
                var age = int.Parse(input[6]);

                var tire = GetNewTire(age, pressure);
                tires.Add(tire);
            }
        }
    }
}