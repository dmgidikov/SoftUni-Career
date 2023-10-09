namespace _05._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .Where(x => x % 2 == 0)
                 .ToArray();

            var queue = new Queue<int>(arr);

            while (queue.Count > 1)
            {
                Console.Write(queue.Dequeue() + ", ");
            }

            Console.WriteLine(queue.Dequeue());
        }
    }
}