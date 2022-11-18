using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Basic_Stack_Operations
{
    internal class Program
    {
        static void Main()
        {
            var commands = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var numsToAdd = commands[0];
            var numsToRemove = commands[1];
            var numToCheck = commands[2];

            var randomNums = Console.ReadLine().Split().Select(int.Parse).ToList();

            var randomStack = new Stack<int>();

            for (int i = 0; i < numsToAdd; i++)
            {
                var temp = randomNums[i];
                randomStack.Push(temp);
            }

            for (int i = 0; i < numsToRemove; i++)
            {
                randomStack.Pop();
            }

            if (randomStack.Contains(numToCheck))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (randomStack.Any())
                {
                    Console.WriteLine(randomStack.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
