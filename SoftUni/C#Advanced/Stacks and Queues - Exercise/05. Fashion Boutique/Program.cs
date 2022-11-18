using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fashion_Boutique
{
    internal class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var randomNum = int.Parse(Console.ReadLine());

            var myStack = new Stack<int>(nums);

            var result = 1;
            var sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
               var currentNum = myStack.Pop();

               if (currentNum + sum <= randomNum)
               {
                   sum += currentNum;
               }
               else
               {
                   sum = currentNum;
                   result++;
               }
            }

            Console.WriteLine(result);
        }
    }
}
