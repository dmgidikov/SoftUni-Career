using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Multiply_Evens_by_Odds
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int randomNum = int.Parse(Console.ReadLine());
			randomNum = Math.Abs(randomNum);

			int result = GetMultipleOfEvenAndOdds(randomNum);
			Console.WriteLine(result);
		}

		static int GetSumOfEvenDigits(int number)
		{
			int result = 0;

			while (number > 0)
			{
				int current = number % 10;

				if (current % 2 == 0)
				{
					result += current;
				}

				number /= 10;
			}

			return result;
		}

		static int GetSumOfOddDigits(int number)
		{
			int result = 0;

			while (number > 0)
			{
				int current = number % 10;

				if (current % 2 != 0)
				{
					result += current;
				}

				number /= 10;
			}

			return result;
		}
		static int GetMultipleOfEvenAndOdds(int number)
		{
			int oddSum = GetSumOfOddDigits(number);
			int evenSum = GetSumOfEvenDigits(number);

			int result = oddSum * evenSum;
			return result;
		}
	}
}
