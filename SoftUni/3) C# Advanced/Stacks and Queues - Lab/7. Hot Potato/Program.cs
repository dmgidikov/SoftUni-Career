using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _7.Hot_Potato
{
    internal class Program
    {
        static void Main()
        {
            var names = Console.ReadLine().Split();
            var num = int.Parse(Console.ReadLine());

            var queue = new Queue<string>(names);
            var starIndex = 1;

            while (queue.Count > 1)
            {
                var currentName = queue.Dequeue();

                if (num == starIndex)
                {
                    Console.WriteLine($"Removed {currentName}");
                    starIndex = 1;
                }
                else
                {
                    queue.Enqueue(currentName);
                    starIndex++;
                }
            }

            var lastPerson = queue.Peek();
            Console.WriteLine($"Last is {lastPerson}");
        }
    }
}
