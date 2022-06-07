using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Max_Sequence_of_Equal_Elements
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] randomNums = Console.ReadLine().Split().Select(int.Parse).ToArray();

			int counter = 0;
			int index = 0;

			for (int i = 0; i < randomNums.Length; i++)
			{
				int currentNumber = randomNums[i];

				int currentCounter = 0;
				int currentIndex = 0;

				for (int j = i + 1; j < randomNums.Length; j++)
				{
					int curentNum = randomNums[j];

					if (currentNumber == curentNum)
					{
						currentCounter++;
						currentIndex = randomNums[i];
					}
					else
					{
						break;
					}
				}

				if (currentCounter > counter)
				{
					counter = currentCounter;
					index = currentIndex;
				}
			}

			for (int i = 0; i < counter + 1; i++)
			{
				Console.Write(index + " ");
			}
		}
	}
}
