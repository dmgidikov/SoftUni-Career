using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Exact_Sum_of_Real_Numbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int numbersToInput = int.Parse(Console.ReadLine());

			decimal sum = 0;

			for (int i = 0; i < numbersToInput; i++)
			{
				decimal randomNumber = decimal.Parse(Console.ReadLine());
				sum += randomNumber;
			}
				
			Console.WriteLine(sum);
		}
	}
}
