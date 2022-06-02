using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Half_Sum_Element
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int inputNumbers = int.Parse(Console.ReadLine());

			int maxNumber = int.MinValue;
			int sum = 0;

			for (int i = 0; i < inputNumbers; i++)
			{
				int currentNumber = int.Parse(Console.ReadLine());

				if (currentNumber > maxNumber)
				{
					maxNumber = currentNumber;
				}

				sum += currentNumber;
			}

			int finalNumber = sum - maxNumber;

			if (maxNumber == finalNumber)
			{
				Console.WriteLine("Yes");
				Console.WriteLine($"Sum = {finalNumber}");
			}
			else
			{
				Console.WriteLine("No");
				Console.WriteLine($"Diff = {Math.Abs(finalNumber - maxNumber)}");
			}
		}
	}
}
