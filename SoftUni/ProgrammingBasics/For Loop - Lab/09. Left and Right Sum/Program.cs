using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Left_and_Right_Sum
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int inputNumber = int.Parse(Console.ReadLine());

			int leftSum = 0;
			int rightSum = 0;

			for (int i = 0; i < 2*inputNumber; i++)
			{
				int currentNumber = int.Parse(Console.ReadLine());				

				if (i < inputNumber)
				{
					leftSum += currentNumber;
				}
				else
				{
					rightSum += currentNumber;
				}
			}

			if (leftSum == rightSum)
			{
				Console.WriteLine($"Yes, sum = {rightSum}");
			}
			else
			{
				Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
			}
		}
	}
}
