namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var stack = new Stack<int>(nums);

            if (stack.Count >= commands[1])
            {
                while (commands[1] > 0)
                {
                    stack.Pop();
                    commands[1]--;
                }
            }

            if (stack.Any())
            {
                if (stack.Contains(commands[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
           
        }
    }
}