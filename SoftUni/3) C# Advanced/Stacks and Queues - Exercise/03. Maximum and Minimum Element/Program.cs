namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();

            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                var command = input[0];

                switch (command)
                {
                    case 1: stack.Push(input[1]); break;
                    case 2:
                        if (stack.Any())
                        {
                            stack.Pop();
                        }
                        break;
                    case 3:
                        if (stack.Any())
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;
                    case 4:
                        if (stack.Any())
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                    default: break;
                };
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
