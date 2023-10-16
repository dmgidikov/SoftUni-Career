namespace _01._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var stack = new Stack<char>(text);

            while (stack.Any())
            {
                Console.Write(stack.Pop());
            }
        }
    }
}