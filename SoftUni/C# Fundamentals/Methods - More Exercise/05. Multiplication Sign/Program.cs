using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Multiplication_Sign
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int num1 = int.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());
			int num3 = int.Parse(Console.ReadLine());

			bool isNum1Positive = ChechPositiveNumbers(num1);
			bool isNum2Positive = ChechPositiveNumbers(num2);
			bool isNum3Positive = ChechPositiveNumbers(num3);
			bool resultPositive = isNum1Positive && isNum2Positive && isNum3Positive;

			bool isNum1Zero = CheckZeroNumber(num1);
			bool isNum2Zero = CheckZeroNumber(num2);
			bool isNum3Zero = CheckZeroNumber(num3);
			bool resultZero = isNum1Zero && isNum2Zero && isNum3Zero;

			PrintSign(resultZero, resultPositive);
		}


		static bool ChechPositiveNumbers(int num)
		{
			if (num >= 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		static bool CheckZeroNumber(int num)
		{
			if (num == 0)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		static void PrintSign(bool resultZero, bool resultPositive)
		{
			if (resultZero == false)
			{
				Console.WriteLine("zero");
			}
			else
			{
				if (resultPositive == true)
				{
					Console.WriteLine("positive");
				}
				else
				{
					Console.WriteLine("negative");
				}
			}
		}
	}
}
