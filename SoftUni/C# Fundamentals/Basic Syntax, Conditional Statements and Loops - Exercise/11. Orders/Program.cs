using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Orders
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int randomInteger = int.Parse(Console.ReadLine());

			double sum = 0;

			for (int i = 0; i < randomInteger; i++)
			{
				double pricePerCapsule = double.Parse(Console.ReadLine());
				int days = int.Parse(Console.ReadLine());
				int capsuleCount = int.Parse(Console.ReadLine());

				double currentSum = pricePerCapsule * days * capsuleCount;
				sum += currentSum;

				Console.WriteLine($"The price for the coffee is: ${currentSum:f2}");
			}
				
			Console.WriteLine($"Total: ${sum:f2}");
		}
	}
}
