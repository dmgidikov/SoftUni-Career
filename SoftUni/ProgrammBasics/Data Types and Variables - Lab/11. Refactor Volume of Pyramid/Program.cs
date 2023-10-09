using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Refactor_Volume_of_Pyramid
{
	internal class Program
	{
		static void Main(string[] args)
		{
						
			double length = double.Parse(Console.ReadLine());
			double width = double.Parse(Console.ReadLine());
			double heigth = double.Parse(Console.ReadLine());

			double area = (length * width * heigth) / 3;

			Console.WriteLine($"Length: Width: Height: Pyramid Volume: {area:f2}");

		}
	}
}
