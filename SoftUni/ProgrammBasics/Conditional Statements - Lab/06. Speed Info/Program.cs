using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Speed_Info
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double someNumber = double.Parse(Console.ReadLine());

			if (someNumber > 1000)
			{
				Console.WriteLine("extremely fast");
			}
			else if (someNumber > 150 && someNumber <= 1000)
			{
				Console.WriteLine("ultra fast");
			}
			else if (someNumber > 50 && someNumber <= 150)
			{
				Console.WriteLine("fast");
			}
			else if (someNumber > 10 && someNumber <= 50)
			{
				Console.WriteLine("average");
			}
			else
			{
				Console.WriteLine("slow");
			}
		}
	}
}
