using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Factorial_Division
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int first = int.Parse(Console.ReadLine());
			int second = int.Parse(Console.ReadLine());

			double firstFact = NumFactorial(first);
			double secondFact = NumFactorial(second);

			double result = firstFact / secondFact;
			Console.WriteLine($"{result:f2}");
		}

		static  double NumFactorial(int num)
		{
			int result = 1;

			for (int i = 1; i <= num; i++)
			{
				result *= i;
			}

			return result;
		}
	}
}
