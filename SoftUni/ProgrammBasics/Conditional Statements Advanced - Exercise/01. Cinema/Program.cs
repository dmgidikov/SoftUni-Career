using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Cinema
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string type = Console.ReadLine();
			int rows = int.Parse(Console.ReadLine());
			int columns = int.Parse(Console.ReadLine());

			double ticketPrice = 0;

			switch (type)
			{
				case "Premiere": ticketPrice = 12; break;
				case "Normal": ticketPrice = 7.5; break;
				default:
					ticketPrice = 5; break;
					break;
			}

			double result = rows * columns * ticketPrice;

			Console.WriteLine($"{result:f2} leva");
		}
	}
}
