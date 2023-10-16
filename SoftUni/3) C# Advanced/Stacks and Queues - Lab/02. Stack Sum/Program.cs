namespace _02_Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var stack = new Stack<int>(arr);

            while (true)
            {
                var command = Console.ReadLine().ToLower().Split();

                if (command[0] == "add")
                {
                    stack.Push(int.Parse(command[1]));
                    stack.Push(int.Parse(command[2]));
                }
                else if (command[0] == "remove")
                {
                    var num = int.Parse(command[1]);

                    if (stack.Count >= num)
                    {
                        for (int i = 0; i < num; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Sum: {stack.Sum()}");
                    break;
                }
            }
        }
    }
}