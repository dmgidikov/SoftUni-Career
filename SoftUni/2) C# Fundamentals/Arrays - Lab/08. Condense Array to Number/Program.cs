using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Condense_Array_to_Number
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] randomNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

			int counter = randomNumbers.Length;

			while (counter > 1)
			{
				for (int i = 0; i < counter - 1; i++)
				{
					randomNumbers[i] += randomNumbers[i + 1];
				}

				counter--;
			}

			Console.WriteLine(randomNumbers[0]);
		}
	}
}
