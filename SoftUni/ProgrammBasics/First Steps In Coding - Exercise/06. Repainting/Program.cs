using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Repainting
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int nylonAmount = int.Parse(Console.ReadLine());
			int paintAmount = int.Parse(Console.ReadLine());
			int paintTinnerAount = int.Parse(Console.ReadLine());
			int hoursWork = int.Parse(Console.ReadLine());

			double nylonPrice = 1.5;
			double paintPrice = 14.5;
			int paintTinnerPrice = 5;

			double moneyForPaint = ((paintAmount + (paintAmount * 0.10)) * paintPrice);
			double moneyForNylon = (nylonAmount + 2) * nylonPrice;
			int moneyForPaintTinner = paintTinnerAount * paintTinnerPrice;
			double moneyForPlasticBags = 0.40;

			double totalSpentMoney = moneyForPaint + moneyForNylon + moneyForPaintTinner + moneyForPlasticBags;
			double workerSallaryPerHour = totalSpentMoney * 0.30;

			double totalWorkerSallary = workerSallaryPerHour * hoursWork;

			Console.WriteLine(totalSpentMoney + totalWorkerSallary);

		}
	}
}
