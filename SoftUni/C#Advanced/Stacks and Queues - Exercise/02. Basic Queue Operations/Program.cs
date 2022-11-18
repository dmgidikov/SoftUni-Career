using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02.Basic_Queue_Operations
{
    internal class Program
    {
        static void Main()
        {
            var commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var randomNums = Console.ReadLine().Split().Select(int.Parse).ToList();

            var numsToAdd = commands[0];
            var numsToRemove = commands[1];
            var numToCheckFor = commands[2];

            var randomQueue = new Queue<int>();

            for (int i = 0; i < numsToAdd; i++)
            {
                var temp = randomNums[i];
                randomQueue.Enqueue(temp);
            }

            for (int i = 0; i < numsToRemove; i++)
            {
                randomQueue.Dequeue();
            }

            if (randomQueue.Contains(numToCheckFor))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (randomQueue.Any())
                {
                    Console.WriteLine(randomQueue.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
