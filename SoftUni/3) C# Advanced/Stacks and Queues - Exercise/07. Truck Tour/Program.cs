namespace _07._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var pumps = new Queue<int[]>();

            EnquePumps(n, pumps);

            var counter = 0;

            while (true)
            {
                var fuelAmount = 0;
                var foundPoint = true;

                foreach (var pump in pumps)
                {
                    fuelAmount += pump[0];

                    if (fuelAmount < pump[1])
                    {
                        foundPoint = false;
                        break;
                    }

                    fuelAmount -= pump[1];
                }

                if (foundPoint)
                {
                    break;
                }

                counter++;

                pumps.Enqueue(pumps.Dequeue());
            }

            Console.WriteLine(counter);

        }

        private static void EnquePumps(int n, Queue<int[]> pumps)
        {
            for (int i = 0; i < n; i++)
            {
                var currentPump = Console.ReadLine().Split().Select(int.Parse).ToArray();
                pumps.Enqueue(currentPump);
            }
        }
    }
}