using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Magic_Sum
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] randomNumbers= Console.ReadLine().Split().Select(int.Parse).ToArray();
			int randomNum = int.Parse(Console.ReadLine());

			for (int i = 0; i < randomNumbers.Length; i++)
			{
				int currentNum = randomNumbers[i];

				for (int j = i + 1; j < randomNumbers.Length; j++) 
				{
					int secondCurrent = randomNumbers[j];

					if (currentNum + secondCurrent == randomNum)
					{
						Console.Write($"{currentNum} {secondCurrent}");
						Console.WriteLine();
						break;
					}
				}
			}
		}
	}
}
