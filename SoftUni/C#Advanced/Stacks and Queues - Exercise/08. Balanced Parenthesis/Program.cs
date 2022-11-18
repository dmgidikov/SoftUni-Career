using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _08.Balanced_Parenthesis
{
    internal class Program
    {
        static void Main()
        {
            var scopesAsString = Console.ReadLine();
            var scopes = scopesAsString.ToCharArray();

            var leftSide = new Stack<char>();
            var rightSide = new Queue<char>();
            var isEqual = true;

            if (scopes.Length % 2 == 1)
            {
                Console.WriteLine("NO");
            }
            else
            {
                for (int i = 0; i < scopes.Length / 2; i++)
                {
                    leftSide.Push(scopes[i]);
                }

                for (int j = scopes.Length / 2; j < scopes.Length; j++)
                {
                    rightSide.Enqueue(scopes[j]);
                }


                while (leftSide.Any() && leftSide.Count == rightSide.Count)
                {
                    var left = leftSide.Pop();
                    var right = rightSide.Dequeue();

                    if (left == '(')
                    {
                        if (right != ')')
                        {
                            isEqual = false;
                            break;
                        }
                    }
                    else if (left == '[')
                    {
                        if (right != ']')
                        {
                            isEqual = false;
                            break;
                        }
                    }
                    else if (left == '{')
                    {
                        if (right != '}')
                        {
                            isEqual = false;
                            break;
                        }
                    }
                }
            }

            if (isEqual == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
