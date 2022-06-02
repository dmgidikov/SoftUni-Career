using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.OddEven
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int randomNumber = int.Parse(Console.ReadLine());

			if (randomNumber % 2 == 0)
			{
				Console.WriteLine("even");
			}
			else
			{
				Console.WriteLine("odd");
			}
		}
	}
}
