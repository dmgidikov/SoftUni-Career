namespace _03._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var stack = new Stack<string>(input.Reverse());

            while (stack.Count > 1)
            {
                var first = int.Parse(stack.Pop());
                var sign = stack.Pop();
                var second = int.Parse(stack.Pop());

                var temp = 0;

                if (sign == "+")
                {
                    temp = first + second;
                }
                else
                {
                    temp = first - second;
                }

                stack.Push(temp.ToString());
            }

            Console.WriteLine(stack.Peek());
        }
    }
}