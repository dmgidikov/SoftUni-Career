using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Calculate_Rectangle_Area
{
	internal class Program
	{
		static void Main()
		{
			double result = GetArea();
			Console.WriteLine(result);
		}

		static double GetArea()
		{
			double firstRandom = double.Parse(Console.ReadLine());
			double secondRandom = double.Parse(Console.ReadLine());
			return firstRandom * secondRandom;
		}
	}
}
