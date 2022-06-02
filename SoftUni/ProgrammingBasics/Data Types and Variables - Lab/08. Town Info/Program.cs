using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Town_Info
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string town = Console.ReadLine();
			int population = int.Parse(Console.ReadLine());
			int area = int.Parse(Console.ReadLine());

			Console.WriteLine($"Town {town} has population of {population} and area {area} square km.");
		}
	}
}
