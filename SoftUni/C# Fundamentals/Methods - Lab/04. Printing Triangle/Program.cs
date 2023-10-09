using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Printing_Triangle
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int randomNum = int.Parse(Console.ReadLine());
			PrintUpperPart(randomNum);
			PrintDownPart(randomNum);
		}

		static void PrintUpperPart(int num)
		{
			for (int i = 1; i <= num; i++)
			{
				for (int j = 0; j < i; j++)
				{
					Console.Write(j + 1 + " ");
				}
				Console.WriteLine();
			}
		}
		static void PrintDownPart(int num)
		{
			for (int i = num - 1; i >= 1; i--)
			{
				for (int j = 0; j < i; j++)
				{
					Console.Write(j + 1 + " ");
				}
				Console.WriteLine();
			}
		}
	}
}
