using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _09.Simple_Text_Editor
{
    internal class Program
    {
        static void Main()
        {
            var commandNumber = int.Parse(Console.ReadLine());

            var myStack = new Queue<char>();
            var allDeletedText = new Queue<char>();

            var allCommands = new Stack<string>();

            for (int i = 0; i < commandNumber; i++)
            {
                var input = Console.ReadLine();

                if (input[0] != '3' && input[0] != '4')
                {
                    allCommands.Push(input);
                }

                if (input.StartsWith("1"))
                {
                    var addText = input.Substring(2);

                    for (int j = 0; j < addText.Length; j++)
                    {
                        myStack.Enqueue(addText[j]);
                    }                   
                }
                else if (input.StartsWith('2'))
                {
                    if (myStack.Any())
                    {
                        var eraseNums = int.Parse(input.Substring(2));

                        if (myStack.Count >= eraseNums)
                        {
                            for (int j = 0; j < eraseNums; j++)
                            {
                                var currentChar = myStack.Peek();
                                myStack.Dequeue();
                                allDeletedText.Enqueue(currentChar);
                            }
                        }
                    }
                }
                else if (input.StartsWith('3'))
                {
                    var getIndex = int.Parse(input.Substring(2));
                    var currentList = new List<char>(myStack);
                    Console.WriteLine(currentList[getIndex - 1]);
                }
                else 
                {
                    var lastCommand = allCommands.Pop();

                    if (lastCommand.StartsWith('1'))
                    {
                        var charsToAdd = lastCommand.Substring(2);

                        for (int j = 0; j < charsToAdd.Length; j++)
                        {
                            var current = myStack.Peek();
                            myStack.Dequeue();
                            allDeletedText.Enqueue(current);
                        }
                    }
                    else
                    {
                        var charsToDelete = lastCommand.Substring(2);
                        var rotations = int.Parse(charsToDelete);

                        for (int j = 0; j < rotations; j++)
                        {
                            var current = allDeletedText.Peek();
                            myStack.Enqueue(current);
                            allDeletedText.Dequeue();
                        }
                    }
                }
            }
        }
    }
}
