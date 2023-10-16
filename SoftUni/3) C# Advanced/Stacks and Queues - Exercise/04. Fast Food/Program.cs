namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var totalFood = int.Parse(Console.ReadLine());
            var orders = Console.ReadLine().Split().Select(int.Parse).ToList();

            var queue = new Queue<int>(orders);
            var biggestOrder = queue.Max();

            Console.WriteLine(biggestOrder);

            while (queue.Any())
            {
                var currentOrder = queue.Peek();

                if (totalFood - currentOrder >= 0)
                {
                    queue.Dequeue();
                    totalFood -= currentOrder;
                }
                else
                {
                    Console.Write("Orders left: ");
                    Console.WriteLine(string.Join(" ", queue));
                    break;
                }
            }

            if (queue.Any() == false)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}