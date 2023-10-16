using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int groupNumber = int.Parse(Console.ReadLine());
			string groupType = Console.ReadLine();
			string weekDay = Console.ReadLine();

			double ticketPrice = 0;

			switch (groupType)
			{
				case "Students":

					if (weekDay == "Friday")
					{
						ticketPrice = 8.45;
					}
					else if (weekDay == "Saturday")
					{
						ticketPrice = 9.8;
					}
					else if (weekDay == "Sunday")
					{
						ticketPrice = 10.46;
					}break;

				case "Business":

					if (weekDay == "Friday")
					{
						ticketPrice = 10.9;
					}
					else if (weekDay == "Saturday")
					{
						ticketPrice = 15.6;
					}
					else if (weekDay == "Sunday")
					{
						ticketPrice = 16;
					}
					break;

				case "Regular":

					if (weekDay == "Friday")
					{
						ticketPrice = 15;
					}
					else if (weekDay == "Saturday")
					{
						ticketPrice = 20;
					}
					else if (weekDay == "Sunday")
					{
						ticketPrice = 22.5;
					}
					break;

				default:
					break;
			}

			double totalPrice = ticketPrice * groupNumber;

			if (groupType == "Students" && groupNumber >= 30)
			{
				totalPrice -= (totalPrice * 0.15);
			}
			else if (groupType == "Business" && groupNumber >= 100)
			{
				totalPrice -= ticketPrice * 10;
			}
			else if (groupType == "Regular" && groupNumber >= 10 && groupNumber <= 20)
			{
				totalPrice -= totalPrice * 0.05;
			}

			Console.WriteLine($"Total price: {totalPrice:f2}");
		}
	}
}
