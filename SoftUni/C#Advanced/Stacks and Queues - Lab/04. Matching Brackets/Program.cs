namespace _04._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var stack = new Stack<int>();

            for (int i = 0; i < text.Length; i++)
            {
                var temp = text[i];

                if (temp == '(')
                {
                    stack.Push(i);
                }
                else if (temp == ')')
                {
                    var startingPoint = stack.Pop();
                    var endingPoint = i - startingPoint + 1;

                    Console.WriteLine(text.Substring(startingPoint, endingPoint));
                }
            }
        }
    }
}