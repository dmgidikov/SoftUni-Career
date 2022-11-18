using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fast_Food
{
    internal class Program
    {
        static void Main()
        {
            var foodNum = int.Parse(Console.ReadLine());

            var foodOrders = Console.ReadLine().Split().Select(int.Parse).ToList();
            var foodOrdersAsQueue = new Queue<int>(foodOrders);

            var biggestClient = foodOrdersAsQueue.Max();

            while (foodOrdersAsQueue.Any())
            {
                var nextOrder = foodOrdersAsQueue.Peek();

                if (foodNum >= nextOrder)
                {
                    foodNum-= nextOrder;
                    foodOrdersAsQueue.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (foodOrdersAsQueue.Any())
            {
                Console.WriteLine(biggestClient);
                Console.Write("Orders left: ");
                Console.WriteLine(string.Join(" ", foodOrdersAsQueue));
                ;
            }
            else
            {
                Console.WriteLine(biggestClient);
                Console.WriteLine("Orders complete");
            }
        }
    }
}
