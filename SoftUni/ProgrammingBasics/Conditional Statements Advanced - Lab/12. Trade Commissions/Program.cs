using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Trade_Commissions
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string city = Console.ReadLine();
			double sales = double.Parse(Console.ReadLine());

			double percentage = 0;

			switch (city)
			{
				case "Sofia":

					if (sales > 10000)
					{
						percentage = 0.12;
					}
					else if (sales <= 10000 && sales > 1000)
					{
						percentage = 0.08;
					}
					else if (sales <= 1000 && sales > 500)
					{
						percentage = 0.07;
					}
					else if (sales <= 500 && sales >= 0)
					{
						percentage = 0.05;
					}
					break;

				case "Varna":

					if (sales > 10000)
					{
						percentage = 0.13;
					}
					else if (sales <= 10000 && sales > 1000)
					{
						percentage = 0.1;
					}
					else if (sales <= 1000 && sales > 500)
					{
						percentage = 0.075;
					}
					else if (sales <= 500 && sales >= 0)
					{
						percentage = 0.045;
					}
					break;

				case "Plovdiv":

					if (sales > 10000)
					{
						percentage = 0.145;
					}
					else if (sales <= 10000 && sales > 1000)
					{
						percentage = 0.12;
					}
					else if (sales <= 1000 && sales > 500)
					{
						percentage = 0.08;
					}
					else if (sales <= 500 && sales >= 0)
					{
						percentage = 0.055;
					}
					break;

				default:
					break;
			}

			double result = percentage * sales;

			if (result <= 0)
			{
				Console.WriteLine("error");
			}
			else
			{
				Console.WriteLine($"{result:f2}");
			}
		}
	}
}
