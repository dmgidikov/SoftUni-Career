using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sum_Even_Numbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] randomNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

			int sum = 0;

			for (int i = 0; i < randomNumbers.Length; i++)
			{
				int currentNumber = randomNumbers[i];

				if (currentNumber % 2 == 0)
				{
					sum += currentNumber;
				}
			}

			Console.WriteLine(sum);
		}
	}
}
