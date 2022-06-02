using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09FishTank
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int lenth = int.Parse(Console.ReadLine());
			int width = int.Parse(Console.ReadLine());
			int high = int.Parse(Console.ReadLine());
			double percentBusy = double.Parse(Console.ReadLine()) / 100;

			int V = lenth * width * high;

			double area = V - V * percentBusy;
			Console.WriteLine(area / 1000);
		}
	}
}
