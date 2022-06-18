using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Top_Number
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int randomNum = int.Parse(Console.ReadLine());

			int sum = 0;
			int countOddDigits = 0;

			for (int i = 10; i < randomNum; i++)
			{
				int temp = i;

				while (temp > 0)
				{
					int current = temp % 10;
					sum += current;
					temp /= 10;

					if (current % 2 != 0)
					{
						countOddDigits++;
					}
				}				

				if (sum % 8 == 0 && countOddDigits > 0)
				{
					PrintTopNumber(i);
				}
				sum = 0;
				countOddDigits = 0;
			}			
		}

		static void PrintTopNumber(int num)
		{
			Console.WriteLine(num);
		}
	}
}
