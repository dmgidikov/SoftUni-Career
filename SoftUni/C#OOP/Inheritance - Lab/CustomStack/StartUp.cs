namespace CustomStack
{
    public class StartUp
    {
        public static void Main()
        {
            var stack = new StackOfStrings();

            stack.Push("Hello");

            var result = stack.IsEmpty();

            Console.WriteLine(result);

            var anotherStack = new StackOfStrings();

            anotherStack.Push("HelloAgain!");
            anotherStack.Push("HelloAgain!");

            stack.AddRange(anotherStack);

            Console.WriteLine(string.Join(" ", stack));
        }
    }
}