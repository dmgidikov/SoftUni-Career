using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Odd_Even_Sum
{
	internal class Program
	{
		static void Main()
		{
			int inputNumber = int.Parse(Console.ReadLine());

			int oddSum = 0;
			int evenSum = 0;

			for (int i = 0; i < inputNumber; i++)
			{
				int currentNumber = int.Parse(Console.ReadLine());

				if (i % 2 == 0)
				{
					evenSum += currentNumber;
				}
				else
				{
					oddSum += currentNumber;
				}
			}

			if (oddSum == evenSum)
			{
				Console.WriteLine("Yes");
				Console.WriteLine($"Sum = {oddSum}");
			}
			else
			{
				Console.WriteLine("No");
				Console.WriteLine($"Diff = {Math.Abs(evenSum - oddSum)}");
			}
		}
	}
}
