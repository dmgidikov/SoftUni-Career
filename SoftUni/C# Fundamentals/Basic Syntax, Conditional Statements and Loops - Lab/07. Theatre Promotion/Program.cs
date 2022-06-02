using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Theatre_Promotion
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string dayType = Console.ReadLine();
			int age = int.Parse(Console.ReadLine());

			int ticketPrice = 0;

			switch (dayType)
			{
				case "Weekday":
					if (age >= 0 && age <= 18)
					{
						ticketPrice = 12;
					}
					else if (age > 18 && age <= 64)
					{
						ticketPrice = 18;
					}
					else if (age > 64 && age <= 122)
					{
						ticketPrice = 12;
					}
					break;
				case "Weekend":
					if (age >= 0 && age <= 18)
					{
						ticketPrice = 15;
					}
					else if (age > 18 && age <= 64)
					{
						ticketPrice = 20;
					}
					else if (age > 64 && age <= 122)
					{
						ticketPrice = 15;
					}
					break;
				default:
					if (age >= 0 && age <= 18)
					{
						ticketPrice = 5;
					}
					else if (age > 18 && age <= 64)
					{
						ticketPrice = 12;
					}
					else if (age > 64 && age <= 122)
					{
						ticketPrice = 10;
					}
					break;
					break;
			}

			if (ticketPrice <= 0)
			{
				Console.WriteLine("Error!");
			}
			else
			{
				Console.WriteLine($"{ticketPrice}$");
			}
		}
	}
}
