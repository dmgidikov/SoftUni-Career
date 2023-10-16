using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var normalQueue = new Queue<char>(input);
            var reversedQueue = new Queue<char>(input.Reverse());

            var compare = new char[]
            {
                '(',
                '{',
                '[',
                ' ',
                ')',
                '}',
                ']',
            };

            var compareWith = new char[]
            {
                ')',
                '}',
                ']',
                ' ',
                '(',
                '{',
                '[',
            };

            while (normalQueue.Any())
            {
                var firstChar = normalQueue.Peek();
                var secondChar = reversedQueue.Peek();

                if (firstChar == compare[0])
                {
                    if (secondChar == compareWith[0] == false)
                    {
                        break;
                    }

                    normalQueue.Dequeue();
                    reversedQueue.Dequeue();
                }
                else if (firstChar == compare[1])
                {
                    if (secondChar == compareWith[1] == false)
                    {
                        break;
                    }

                    normalQueue.Dequeue();
                    reversedQueue.Dequeue();
                }
                else if (firstChar == compare[2])
                {
                    if (secondChar == compareWith[2] == false)
                    {
                        break;
                    }

                    normalQueue.Dequeue();
                    reversedQueue.Dequeue();
                }
                else if (firstChar == compare[3])
                {
                    if (secondChar == compareWith[3] == false)
                    {
                        break;
                    }

                    normalQueue.Dequeue();
                    reversedQueue.Dequeue();
                }
                else if (firstChar == compare[4])
                {
                    if (secondChar == compareWith[4] == false)
                    {
                        break;
                    }

                    normalQueue.Dequeue();
                    reversedQueue.Dequeue();
                }
                else if (firstChar == compare[5])
                {
                    if (secondChar == compareWith[5] == false)
                    {
                        break;
                    }

                    normalQueue.Dequeue();
                    reversedQueue.Dequeue();
                }
                else if (firstChar == compare[6])
                {
                    if (secondChar == compareWith[6] == false)
                    {
                        break;
                    }

                    normalQueue.Dequeue();
                    reversedQueue.Dequeue();
                }
            }

            if (normalQueue.Any())
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}