using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Cinema_Ticket
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string ramdonmWeekDay = Console.ReadLine();

			switch (ramdonmWeekDay)
			{
				case "Monday":
				case "Tuesday":
				case "Friday":
					Console.WriteLine(12); break;
				case "Wednesday":
				case "Thursday":
					Console.WriteLine(14); break;
				default:
					Console.WriteLine(16); break;
			}
		}
	}
}
