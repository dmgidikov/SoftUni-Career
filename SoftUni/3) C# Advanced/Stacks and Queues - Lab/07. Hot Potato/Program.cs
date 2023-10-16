namespace _07._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split();
            var rotations = int.Parse(Console.ReadLine());

            var queue = new Queue<string>(names);

            while (queue.Count > 1)
            {
                for (int i = 0; i < rotations - 1; i++)
                {
                    var name = queue.Dequeue();
                    queue.Enqueue(name);
                }

                var remove = queue.Dequeue();
                Console.WriteLine($"Removed {remove}");
            }
            var last = queue.Dequeue();
            Console.WriteLine($"Last is {last}");
        }
    }
}