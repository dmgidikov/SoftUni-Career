using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sum_of_Odd_Numbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int randomNumber = int.Parse(Console.ReadLine());

			int sum = 0;

			for (int i = 1; i <= randomNumber * 2; i++)
			{
				if (i % 2 == 0)
				{
					continue;
				}
				else
				{
					sum += i;
					Console.WriteLine(i);
				}				
			}

			Console.WriteLine($"Sum: {sum}");
		}
	}
}
