namespace _05.StackOfStrings
{
    public class StartUp
    {
        public static void Main()
        {
            var customStack = new CustomStack();

            Console.WriteLine(customStack.IsEmpty());

            var range = new Stack<string>();

            range.Push("1");
            range.Push("2");
            range.Push("3");

            customStack.AddRange(range);

            foreach (var item in customStack)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}