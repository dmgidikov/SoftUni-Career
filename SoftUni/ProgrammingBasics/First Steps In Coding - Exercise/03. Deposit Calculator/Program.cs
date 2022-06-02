using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03DepositCalculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double depositAmount = double.Parse(Console.ReadLine());
			int depositPeriod = int.Parse(Console.ReadLine());
			double apy = double.Parse(Console.ReadLine()) / 100;

			double result = depositAmount + depositPeriod * ((depositAmount * apy) / 12);

			Console.WriteLine(result);
		}
	}
}
