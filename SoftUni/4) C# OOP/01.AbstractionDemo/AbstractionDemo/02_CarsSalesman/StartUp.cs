namespace _02_CarsSalesman
{
    public class StartUp
    {
        public static void Main()
        {
            var input = int.Parse(Console.ReadLine());

            var engines = new List<Engine>();

            for (int i = 0; i < input; i++)
            {
                var engineData = Console.ReadLine().Split();

                var tempEngine = CreateEngine(engineData);
                engines.Add(tempEngine);
            }

            var nextInput = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < nextInput; i++)
            {
                var carData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var tempCar = CreateCar(carData, engines);
                cars.Add(tempCar);
            }

            foreach (var car in cars)
                Console.WriteLine(car);
        }

        private static Car CreateCar(string[] carData, List<Engine> engines)
        {
            var model = carData[0];
            var Engine = engines.Where(x => x.Model == carData[1]).FirstOrDefault();

            var car = new Car(model, Engine);

            if (carData.Length > 3)
            {
                var weight = int.Parse(carData[2]);
                var color = carData[3];

                car.Color = color;
                car.Weight = weight;
            }
            else if (carData.Length > 2)
            {
                int temp;

                if (int.TryParse(carData[2], out temp))
                {
                    car.Weight = temp;
                }
                else
                {
                    car.Color = carData[2];
                }  
            }

            return car;
        }

        private static Engine CreateEngine(string[] engineData)
        {
            var model = engineData[0];
            var power = int.Parse(engineData[1]);

            var engine = new Engine(model, power);

            if (engineData.Length > 3)
            {
                var displacement = int.Parse(engineData[2]); 
                var efficiency = engineData[3];

                engine.Displacement = displacement;
                engine.Efficientcy = efficiency;
            }
            else if (engineData.Length > 2)
            {
                int temp;

                if (int.TryParse(engineData[2], out temp))
                {
                    engine.Displacement = temp;
                }
                else
                {
                    engine.Efficientcy = engineData[2];
                }
            }

            return engine;
        
        }
    }
}