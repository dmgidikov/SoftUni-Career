namespace _08._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var carsPast = int.Parse(Console.ReadLine());

            var totalCars = new Queue<string>();
            var passedCars = new Queue<string>();

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "green")
                {
                    for (int i = 0; i < carsPast; i++)
                    {
                        if (totalCars.Any())
                        {
                            var car = totalCars.Dequeue();
                            passedCars.Enqueue(car);
                            Console.WriteLine($"{car} passed!");
                        }
                    }
                }
                else if (command == "end")
                {
                    Console.WriteLine(passedCars.Count + " cars passed the crossroads.");
                    break;
                }
                else
                {
                    totalCars.Enqueue(command);
                }
            }
        }
    }
}