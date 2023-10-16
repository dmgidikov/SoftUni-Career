using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Equal_Arrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

			int sum = 0;
			int counter = 0;

			for (int i = 0; i < firstArray.Length; i++)
			{
				int firstArrayNumbers = firstArray[i];
				int secondArrayNumbers = secondArray[i];

				if (firstArrayNumbers == secondArrayNumbers)
				{
					sum += firstArrayNumbers;
					counter++;
				}
				else
				{
					Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
					break;
				}
			}

			if (firstArray.Length == counter)
			{
				Console.WriteLine($"Arrays are identical. Sum: {sum}");
			}
		}
	}
}
