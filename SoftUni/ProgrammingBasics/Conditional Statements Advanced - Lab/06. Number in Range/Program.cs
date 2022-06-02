using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Number_in_Range
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int someNumber = int.Parse(Console.ReadLine());

			if (someNumber == 0)
			{
				Console.WriteLine("No");
			}
			else if (someNumber >= -100 && someNumber <= 100)
			{
				Console.WriteLine("Yes");
			}
			else 
			{
				Console.WriteLine("No");
			}
		}
	}
}
