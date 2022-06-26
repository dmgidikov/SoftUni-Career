using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Merging_Lists
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> firstNUms = Console.ReadLine().Split().Select(int.Parse).ToList();
			List<int> secondNums = Console.ReadLine().Split().Select(int.Parse).ToList();

			int firsNumsCount = firstNUms.Count();
			int secondNumsCount = secondNums.Count();

			int shorterCount = Math.Min(firsNumsCount, secondNumsCount);
			

			List<int> result = new List<int>();

			for (int i = 0; i < shorterCount; i++)
			{
				result.Add(firstNUms[i]);
				result.Add(secondNums[i]);
			}

			if (firsNumsCount != secondNumsCount)
			{
				if (firsNumsCount > secondNumsCount)
				{
					for (int i = secondNumsCount; i < firsNumsCount; i++)
					{
						result.Add(firstNUms[i]);
					}
				}
				else
				{
					for (int i = firsNumsCount; i < secondNumsCount; i++)
					{
						result.Add(secondNums[i]);
					}
				}
			}

			Console.WriteLine(String.Join(" ", result));
		}
	}
}
