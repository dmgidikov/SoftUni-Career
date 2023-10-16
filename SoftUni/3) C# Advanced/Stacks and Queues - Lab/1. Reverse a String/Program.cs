using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _1.Reverse_a_String
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var stack = new Stack<char>(input);

            while (stack.Any())
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
