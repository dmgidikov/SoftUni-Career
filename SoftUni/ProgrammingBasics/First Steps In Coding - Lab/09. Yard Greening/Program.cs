using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YardGreening
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double area = double.Parse(Console.ReadLine());
			double pricePerMeter = 7.61;
			double discount = 0.18;

			double totalPriceBeforeDiscount = area * pricePerMeter;
			double totalPriceAfterDiscount = discount * totalPriceBeforeDiscount;

			Console.WriteLine($"The discount is: {totalPriceBeforeDiscount - totalPriceAfterDiscount} lv.");
			Console.WriteLine($"The final price is: {totalPriceAfterDiscount} lv.");

		}
	}
}
