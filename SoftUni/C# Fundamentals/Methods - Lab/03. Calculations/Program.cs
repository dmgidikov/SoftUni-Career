using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Calculations
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string command = Console.ReadLine();
			double firstNum = double.Parse(Console.ReadLine());
			double secondNum = double.Parse(Console.ReadLine());

			if (command == "add")
			{
				PrintSum(firstNum, secondNum);
			}
			else if (command == "subtract")
			{
				PrintSubtract(firstNum, secondNum);
			}
			else if (command == "multiply")
			{
				PrintMultiply(firstNum, secondNum);
			}
			else if (command == "divide")
			{
				PrintDivide(firstNum, secondNum);
			}
		}

		static void PrintSum(double first, double second)
		{
			Console.WriteLine(first + second);
		}
		static void PrintSubtract(double first, double second)
		{
			Console.WriteLine(first - second);
		}
		static void PrintMultiply(double first, double second)
		{
			Console.WriteLine(first * second);
		}
		static void PrintDivide(double first, double second)
		{
			Console.WriteLine(first / second);
		}
	}
}
