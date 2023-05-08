namespace _06._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "Paid")
                {
                    if (queue.Any())
                    {
                        foreach (var name in queue)
                        {
                            Console.WriteLine(name);
                        }

                        queue.Clear();
                    }
                }
                else if (command == "End")
                {
                    Console.WriteLine($"{queue.Count} people remaining.");
                    break;
                }
                else
                {
                    queue.Enqueue(command);
                }
            }
        }
    }
}