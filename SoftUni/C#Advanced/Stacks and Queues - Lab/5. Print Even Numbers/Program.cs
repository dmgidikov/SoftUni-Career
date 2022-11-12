using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _5.Print_Even_Numbers
{
    internal class Program
    {
        static void Main()
        {
            var randomNums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var queue = new Queue<int>();

            for (int i = 0; i < randomNums.Length; i++)
            {
                var currentNum = randomNums[i];

                if (currentNum % 2 == 0)
                {
                   queue.Enqueue(currentNum);
                }
            }

            while (queue.Count > 1)
            {
                var currentNum = queue.Dequeue();
                Console.Write(currentNum + ", ");
            }

            Console.WriteLine(queue.Peek());
        }
    }
}
