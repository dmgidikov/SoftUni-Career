using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Convert_Meters_to_Kilometers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double metres = double.Parse(Console.ReadLine());

			double kilemeters = metres / 1000;

			Console.WriteLine($"{kilemeters:f2}");
		}
	}
}
