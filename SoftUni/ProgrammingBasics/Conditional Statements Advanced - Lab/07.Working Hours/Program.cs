using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Working_Hours
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int randomHour = int.Parse(Console.ReadLine());
			string ramdonWeekDay = Console.ReadLine();

			if (ramdonWeekDay == "Sunday")
			{
				Console.WriteLine("closed");
			}
			else
			{
				if (randomHour >= 10 && randomHour <= 18)
				{
					Console.WriteLine("open");
				}
				else
				{
					Console.WriteLine("closed");
				}
			}
		}
	}
}
