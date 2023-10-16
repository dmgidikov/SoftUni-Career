using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Multiplication_Table_2._0
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int numberToMultiplicate = int.Parse(Console.ReadLine());
			int startingPoint = int.Parse(Console.ReadLine());

			for (int i = startingPoint; i <= 10; i++)
			{
				Console.WriteLine($"{numberToMultiplicate} X {i} = {numberToMultiplicate * i}");
			}

			if (startingPoint > 10)
			{
				Console.WriteLine($"{numberToMultiplicate} X {startingPoint} = {numberToMultiplicate * startingPoint}");
			}
		}
	}
}
