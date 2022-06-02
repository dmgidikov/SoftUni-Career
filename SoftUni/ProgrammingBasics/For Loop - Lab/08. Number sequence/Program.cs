using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Number_sequence
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int numberOfInputs = int.Parse(Console.ReadLine());

			int smallestNumber = int.MinValue;
			int biggestNumber = int.MaxValue;


			for (int i = 0; i < numberOfInputs; i++)
			{
				int currentNumber = int.Parse(Console.ReadLine());

				if (currentNumber > smallestNumber)
				{
					smallestNumber = currentNumber;
				}

				if (currentNumber < biggestNumber)
				{
					biggestNumber = currentNumber;
				}
			}

			Console.WriteLine($"Max number: {smallestNumber}");
			Console.WriteLine($"Min number: {biggestNumber}");
		}
	}
}
