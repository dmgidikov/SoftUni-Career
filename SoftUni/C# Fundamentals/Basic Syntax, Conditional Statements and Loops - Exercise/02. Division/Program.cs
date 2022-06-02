using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Division
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int someNumber = int.Parse(Console.ReadLine());

			if (someNumber % 10 == 0)
			{
				Console.WriteLine("The number is divisible by 10");
			}
			else if (someNumber % 7 == 0)
			{
				Console.WriteLine("The number is divisible by 10");
			}
			else if (someNumber % 6 == 0)
			{
				Console.WriteLine("The number is divisible by 6");
			}			
			else if (someNumber % 3 == 0)
			{
				Console.WriteLine("The number is divisible by 3");
			}
			else if (someNumber % 2 == 0)
			{
				Console.WriteLine("The number is divisible by 2");
			}
			else
			{
				Console.WriteLine("Not divisible");
			}
		}
	}
}
