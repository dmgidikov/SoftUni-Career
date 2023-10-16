using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _6.Jagged_Array_Modification
{
    internal class Program
    {
        static void Main()
        {
            var dimensions = int.Parse(Console.ReadLine());

            var jagged = new int[dimensions][];

            for (int row = 0; row < dimensions; row++)
            {
                var currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();

                jagged[row] = currentRow;
            }

            while (true)
            {
                var command = Console.ReadLine().Split();

                if (command[0] == "END")
                {
                    break;
                }

                var currentRow = int.Parse(command[1]);
                var currentCol = int.Parse(command[2]);
                var value = int.Parse(command[3]);

                if (command[0] == "Add")
                {
                    if (currentRow <= dimensions && currentCol <= jagged[currentRow].Length)
                    {
                        jagged[currentRow][currentCol] += value;
                    }
                }
                else if (command[0] == "Subtract")
                {
                    if (currentRow <= dimensions && currentCol <= jagged[currentRow].Length)
                    {
                        jagged[currentRow][currentCol] -= value;
                    }
                }
            }

            for (int row = 0; row < dimensions; row++)
            {
                Console.WriteLine(string.Join(" ", jagged[row]));
            }
        }
    }
}
