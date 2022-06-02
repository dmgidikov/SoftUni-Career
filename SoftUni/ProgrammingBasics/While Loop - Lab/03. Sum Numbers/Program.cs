using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int numbers = int.Parse(Console.ReadLine());

			int sum = 0;

			while (numbers > sum)
			{
				int tempNum = int.Parse(Console.ReadLine());
				sum += tempNum;
			}

			Console.WriteLine(sum);
		}
	}
}
