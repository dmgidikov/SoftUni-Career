using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Strong_number
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string randomNumber = Console.ReadLine();
			int inputAsInt = int.Parse(randomNumber);
			int compareTo = inputAsInt;
			int sum = 0;

			for (int i = 0; i < randomNumber.Length; i++)
			{
				int currentNumber = inputAsInt % 10;
				inputAsInt /= 10;
				int currentSum = 1;

				for (int j = 1; j <= currentNumber; j++)
				{
					currentSum *= j;
				}

				sum += currentSum;
			}

			if (compareTo == sum)
			{
				Console.WriteLine("yes");
			}
			else
			{
				Console.WriteLine("no");
			}
		}
	}
}
