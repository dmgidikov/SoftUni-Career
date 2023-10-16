using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Top_Integers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] randomNums = Console.ReadLine().Split().Select(int.Parse).ToArray();

			for (int i = 0; i < randomNums.Length - 1; i++)
			{
				int currentNumber = randomNums[i];
				int biggerNumber = currentNumber;

				for (int j = i + 1; j < randomNums.Length; j++)
				{
					int current = randomNums[j];

					if (currentNumber < current) 
					{
						biggerNumber = current;
						break;
					}
					else
					{
						biggerNumber = current;
					}
				}

				if (currentNumber > biggerNumber)
				{
					Console.Write(currentNumber + " ");
				}
			}

			Console.WriteLine(randomNums[randomNums.Length - 1]);
		}
	}
}
