using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _2.Stack_Sum
{
    internal class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var stack = new Stack<int>(nums);

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
                    var numToRemoves = int.Parse(command[1]);

                    if (stack.Count > numToRemoves)
                    {
                        for (int i = 0; i < numToRemoves; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                else
                {
                    break;
                }
            }

            var result = stack.Sum();

            Console.WriteLine($"Sum: {result}");
        }
    }
}
