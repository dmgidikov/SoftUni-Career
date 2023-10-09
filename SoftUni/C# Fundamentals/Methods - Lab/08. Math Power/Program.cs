using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Math_Power
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double randomNumber = double.Parse(Console.ReadLine());
			double power = double.Parse(Console.ReadLine());

			double result = GetResult(randomNumber, power);

			Console.WriteLine(result);
		}

		static double GetResult(double number, double power)
		{
			double result = 1;

			for (int i = 0; i < power; i++)
			{
				result *= number;
			}

			return result;
		}
	}
}
