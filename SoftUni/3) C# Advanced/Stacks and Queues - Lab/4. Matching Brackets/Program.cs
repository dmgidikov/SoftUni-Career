using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _4.Matching_Brackets
{
    internal class Program
    {
        static void Main()
        {
            var text = Console.ReadLine();

            var stack = new Stack<int>();

            for (int i = 0; i < text.Length; i++)
            {
                var symbol = text[i];

                if (symbol == '(')
                {
                    stack.Push(i);
                }
                else if (symbol == ')')
                {
                    var indexOfOpeningBracket = stack.Pop();
                    var indexOfClosingBracket = i - indexOfOpeningBracket + 1;

                    var result = text.Substring(
                        indexOfOpeningBracket, indexOfClosingBracket);

                    Console.WriteLine(result);
                }
            }
        }
    }
}
     