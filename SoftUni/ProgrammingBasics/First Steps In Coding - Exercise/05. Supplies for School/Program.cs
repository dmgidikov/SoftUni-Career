using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SuppliesForSchool
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int penAmonut = int.Parse(Console.ReadLine());
			int markerAmount = int.Parse(Console.ReadLine());
			int detergentAmountInLiters = int.Parse(Console.ReadLine());
			int discount = int.Parse(Console.ReadLine());

			double penPrice = penAmonut * 5.80;
			double markersPrice = markerAmount * 7.20;
			double detergentPrice = detergentAmountInLiters * 1.20;

			double priceBeforeDiscount = penPrice + markersPrice + detergentPrice;
			double priceAfterDiscount = (priceBeforeDiscount * discount) / 100;

			double finalPrice = priceBeforeDiscount - priceAfterDiscount;
			Console.WriteLine(finalPrice);
		}
	}
}
