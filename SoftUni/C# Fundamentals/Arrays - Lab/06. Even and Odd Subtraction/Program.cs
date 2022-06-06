using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Even_and_Odd_Subtraction
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] randomNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

			int evenSUm = 0;
			int oddSum = 0;

			for (int i = 0; i < randomNumbers.Length; i++)
			{
				int currentNumber = randomNumbers[i];

				if (currentNumber % 2 == 0)
				{
					evenSUm += currentNumber;
				}
				else
				{
					oddSum += currentNumber;
				}
			}

			Console.WriteLine(evenSUm - oddSum);
		}
	}
}
