using System.Text;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rotations = int.Parse(Console.ReadLine());

            var text = string.Empty;
            var stack = new Stack<string>();
            stack.Push(text);

            for (int i = 0; i < rotations; i++)
            {
                var input = Console.ReadLine().Split();
                var lastText = stack.Peek();

                var command = input[0];

                if (command == "1")
                {
                    var currentText = input[1];

                    lastText += currentText;
                    stack.Push(lastText);
                }
                else if (command == "2")
                {
                    var temp = int.Parse(input[1]);

                    if (lastText.Length > temp)
                    {
                        lastText.Substring(lastText.Length - temp, temp);
                        stack.Push(lastText);
                    }
                    else
                    {
                        var newText = string.Empty;
                        stack.Push(newText);
                    }
                }
                else if (command == "3")
                {
                    var index = int.Parse(input[1]);

                    if (lastText.Length >= index)
                    {
                        Console.WriteLine(lastText[index - 1]);
                    }
                }
                else if (command == "4")
                {
                    stack.Pop();
                }
            }
        }
    }
}