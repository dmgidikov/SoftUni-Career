using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Zig_Zag_Arrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int randomNumber = int.Parse(Console.ReadLine());

			int[] firstArray = new int[randomNumber];
			int[] secondArray = new int[randomNumber];

			for (int i = 0; i < randomNumber; i++)
			{
				int[] currentArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
				int firstNumber = currentArray[0];
				int secondNumber = currentArray[1];

				if (i % 2 == 0)
				{
					firstArray[i] = firstNumber;
					secondArray[i] = secondNumber;
				}
				else
				{
					firstArray[i] = secondNumber;
					secondArray[i] = firstNumber;
				}
			}

			Console.Write(String.Join(" ", firstArray));
			Console.WriteLine();
			Console.Write(String.Join(" ", secondArray));
			Console.WriteLine();
		}
	}
}
