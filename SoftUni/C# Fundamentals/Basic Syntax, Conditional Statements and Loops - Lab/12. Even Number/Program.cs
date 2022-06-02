using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Even_Number
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				int evenNumber = int.Parse(Console.ReadLine());

				if (evenNumber % 2 == 0)
				{
					Console.WriteLine($"The number is: {Math.Abs(evenNumber)}");
					break;
				}
				else
				{
					Console.WriteLine("Please write an even number.");
				}
			}
		}
	}
}
