using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Godzilla_vs.Kong
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double budget = double.Parse(Console.ReadLine());
			int workers = int.Parse(Console.ReadLine());
			double pricePerWorker = double.Parse(Console.ReadLine());

			double decorMoney = budget * 0.1;
			double totalWorkersMoney = pricePerWorker * workers;

			if (workers > 150)
			{
				totalWorkersMoney -= totalWorkersMoney * 0.1;
			}

			double neededMoney = decorMoney + totalWorkersMoney;

			if (neededMoney > budget)
			{
				Console.WriteLine("Not enough money!");
				Console.WriteLine($"Wingard needs {neededMoney - budget:f2} leva more.");
			}
			else
			{
				Console.WriteLine("Action!");
				Console.WriteLine($"Wingard starts filming with {budget - neededMoney:f2} leva left.");
			}			
		}
	}
}
