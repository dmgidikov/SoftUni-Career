using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Remove_Negatives_and_Reverse
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> randomNums = Console.ReadLine().Split().Select(int.Parse).ToList();

			for (int i = 0; i < randomNums.Count; i++)
			{
				if (randomNums[i] < 0)
				{
					randomNums.RemoveAt(i);
					i = -1;
				}
			}

			randomNums.Reverse();

			if (randomNums.Count < 1)
			{
				Console.WriteLine("empty");
			}
			else
			{
				Console.WriteLine(String.Join(" ", randomNums));
			}
		}
	}
}
