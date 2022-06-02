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

			if (!(someNumber >= 100 && someNumber <= 200 || someNumber == 0))
			{
				Console.WriteLine("invalid");
			}
		}
	}
}
