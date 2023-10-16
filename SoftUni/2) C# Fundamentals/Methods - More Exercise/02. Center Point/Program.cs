using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Center_Point
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double firtUp = int.Parse(Console.ReadLine());
			double firtDown = int.Parse(Console.ReadLine());
			double secondUp = int.Parse(Console.ReadLine());
			double secondDown = int.Parse(Console.ReadLine());			

			PrintNearestElement(firtUp, firtDown, secondUp, secondDown);
		}

		static void PrintNearestElement(double firtUp, double firtDown, double secondUp, double secondDown)
		{
			double firstResult = firtUp + firtDown;
			double secondResult = secondUp + secondDown;

			if (firstResult <= secondResult)
			{
				Console.WriteLine($"({firtUp}, {firtDown})");
			}
			else
			{
				Console.WriteLine($"({secondUp}, {secondDown})");
			}
		}
	}
}
