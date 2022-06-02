using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Numbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int randomNumber = int.Parse(Console.ReadLine());

			for (int i = 1; i <= randomNumber; i++)
			{
				int sum = 0;
				int currentNumber = i;

				while (currentNumber != 0)
				{
					int lastDigit = currentNumber % 10;
					currentNumber /= 10;
					sum += lastDigit;
				}

				if (sum == 5 || sum == 7 || i == 11)
				{
					Console.WriteLine($"{i} -> True");
				}
				else
				{
					Console.WriteLine($"{i} -> False");
				}
			}
		}
	}
}
