using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Equal_Sum
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] randomNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

			int counter = 0;

			for (int i = 0; i < randomNumbers.Length; i++)
			{
				int currentNumber = randomNumbers[i];

				int sumBeforeNumber = 0;
				int sumAfterNumber = 0;

				for (int j = 0; j < i; j++)
				{
					int currentNum = randomNumbers[j];
					sumBeforeNumber+= currentNum;
				}

				for (int k = i + 1; k < randomNumbers.Length; k++)
				{
					int currentNum = randomNumbers[k];
					sumAfterNumber+= currentNum;
				}

				if (sumBeforeNumber == sumAfterNumber)
				{
					Console.WriteLine(i);
					counter = 0;
					break;
				}
				else
				{
					counter++;
				}
			}

			if (counter != 0)
			{
				Console.WriteLine("no");
			}
		}
	}
}
