using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Characters_in_Range
{
	internal class Program
	{
		static void Main(string[] args)
		{
			char first = char.Parse(Console.ReadLine());
			char second = char.Parse(Console.ReadLine());

			if (first < second)
			{
				PrintFirstToSecond(first, second);
			}
			else
			{
				PrintSecondToFirst(first, second);
			}
		}

		static void PrintFirstToSecond(int first, int second)
		{
			for (int i = first+1; i < second; i++)
			{
				Console.Write((char)i + " ");
			}
		}

		static void PrintSecondToFirst(int first, int second)
		{
			for (int i = second+1; i < first; i++)
			{
				Console.Write((char)i + " ");
			}
		}
	}
}
