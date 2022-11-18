using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _03.Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main()
        {
            var commands = int.Parse(Console.ReadLine());

            var randomStack = new Stack<int>();

            for (int i = 0; i < commands; i++)
            {
                var command = Console.ReadLine().Split().Select(int.Parse).ToArray();

                switch (command[0])
                {
                    case 1: randomStack.Push(command[1]); break;
                    case 2:
                        if (randomStack.Any())
                        {
                            randomStack.Pop();
                        }
                        break;
                    case 3:

                        if (randomStack.Any())
                        {
                            var maxElement = randomStack.Max();
                            Console.WriteLine(maxElement);
                        }
                        break;
                    case 4:

                        if (randomStack.Any())
                        {
                            var minElement = randomStack.Min();
                            Console.WriteLine(minElement);
                        }
                        break;
                }

                Console.WriteLine(string.Join(", ", randomStack));
            }
        }
    }
}
