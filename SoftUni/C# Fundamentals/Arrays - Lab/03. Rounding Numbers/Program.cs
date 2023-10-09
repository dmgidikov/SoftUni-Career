using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Rounding_Numbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double[] randomNumbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

			for (int i = 0; i < randomNumbers.Length; i++)
			{
				double currentDouble = randomNumbers[i];
				int roundedNumber = (int)Math.Round(currentDouble, MidpointRounding.AwayFromZero);

				Console.WriteLine($"{currentDouble} => {roundedNumber}");
			}

		}
	}
}
