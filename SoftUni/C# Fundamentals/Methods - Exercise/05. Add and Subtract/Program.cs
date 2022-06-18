using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Add_and_Subtract
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int first = int.Parse(Console.ReadLine());
			int second = int.Parse(Console.ReadLine());
			int third = int.Parse(Console.ReadLine());

			int sum = SumFirstAndSecod(first, second);
			int result = SubtractResultAndThird(sum, third);
			Console.WriteLine(result);

		}

		static int SumFirstAndSecod(int first, int second)
		{
			return first + second;
		}

		static int SubtractResultAndThird(int result, int third)
		{
			return result - third;
		}
	}
}
