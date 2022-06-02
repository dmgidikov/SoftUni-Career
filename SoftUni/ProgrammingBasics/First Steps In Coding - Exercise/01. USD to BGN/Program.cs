using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStepsInCodingExercise
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double usdDollar = double.Parse(Console.ReadLine());

			double usdDollarToBgn = 1.79549;
			double result = usdDollar * usdDollarToBgn;

			Console.WriteLine(result);
		}
	}
}
