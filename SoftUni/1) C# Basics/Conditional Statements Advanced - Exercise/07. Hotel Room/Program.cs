using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Hotel_Room
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string month = Console.ReadLine().ToLower();
			int nights = int.Parse(Console.ReadLine());

			decimal apartmentPricePerNight = 0;
			decimal studioPricePerNight = 0;

			if (month == "may" || month == "october")
			{
				apartmentPricePerNight = 65;
				studioPricePerNight = 50;

				if (nights > 14)
				{	
					studioPricePerNight -= studioPricePerNight * 0.30m;
				}
				else if (nights > 7)
				{
					studioPricePerNight -= studioPricePerNight * 0.05m;
				}

			}
			else if (month == "june" || month == "september")
			{
				apartmentPricePerNight = 68.70m;
				studioPricePerNight = 75.20m;

				if (nights > 14)
				{
					studioPricePerNight -= studioPricePerNight * 20;
				}
			}
			else if (month == "july" || month == "august")
			{
				apartmentPricePerNight = 77;
				studioPricePerNight = 76;
			}

			if (nights > 14)
			{
				apartmentPricePerNight -= apartmentPricePerNight * 0.1m;
			}

			decimal totalApartament = apartmentPricePerNight * nights;
			decimal totalStudio = studioPricePerNight * nights;

			Console.WriteLine($"Apartment: {totalApartament:f2} lv.");
			Console.WriteLine($"Studio: {totalStudio:f2} lv.");
		}
	}
}
