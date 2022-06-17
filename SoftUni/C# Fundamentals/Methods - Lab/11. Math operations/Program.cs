using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Math_operations
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int firstNum = int.Parse(Console.ReadLine());
			string operation = Console.ReadLine();
			int secondNum = int.Parse(Console.ReadLine());

			double result = Calculate(firstNum, operation, secondNum);
			Console.WriteLine(result);
		}

		static double Calculate(int first, string operation, int second)
		{
			double result = 0;

			switch (operation)
			{
				case "+": result = first + second; break;
				case "-": result = first - second; break;
				case "*": result = first * second; break;
				case "/": result = first / second; break;
				default:
					break;
			}
			return result;
		}
	}
}
