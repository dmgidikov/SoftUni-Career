namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var queue = new Queue<int>(nums);

            if (queue.Count >= commands[1])
            {
                while (commands[1] > 0)
                {
                    queue.Dequeue();
                    commands[1]--;
                }
            }

            if (queue.Any())
            {
                if (queue.Contains(commands[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }

        }
    }
}