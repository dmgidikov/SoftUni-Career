using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Smallest_of_Three_Numbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int firstNum = int.Parse(Console.ReadLine());
			int secondNum = int.Parse(Console.ReadLine());
			int thirdNum = int.Parse(Console.ReadLine());

			int result = Math.Min(firstNum, (Math.Min(secondNum, thirdNum)));
			PrintSmallestNumber(result);
		}

		static void PrintSmallestNumber(int num)
		{
			Console.WriteLine(num);
		}
	}
}
