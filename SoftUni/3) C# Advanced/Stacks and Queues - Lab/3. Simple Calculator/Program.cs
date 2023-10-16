using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _3.Simple_Calculator
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();

            var result = new Stack<string>(input.Reverse());

            while (true)
            {
                if (result.Count > 1 == false)
                {
                    break;
                }

                var first = int.Parse(result.Pop());
                var operation = result.Pop();
                var second = int.Parse(result.Pop());

                var temptResult = operation switch
                {
                    "+" => first + second,
                    "-" => first - second,
                    _ => 0
                };

                result.Push(temptResult.ToString());
            }

            Console.WriteLine(result.Pop());
        }
    }
}
