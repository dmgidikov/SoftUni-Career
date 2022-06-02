using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Operations_Between_Numbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double firstNumber = double.Parse(Console.ReadLine());
			double secondNumber = double.Parse(Console.ReadLine());
			char operation = char.Parse(Console.ReadLine());

			double result = 0;

			if (secondNumber != 0)
			{
				switch (operation)
				{
					case '+': result = firstNumber + secondNumber; break;
					case '-': result = firstNumber - secondNumber; break;
					case '*': result = firstNumber * secondNumber; break;
					case '/': result = firstNumber / secondNumber; break;
					case '%': result = firstNumber % secondNumber; break;
					default:
						break;
				}

				if (operation == '+' || operation == '-' || operation == '*')
				{
					if (result % 2 == 0)
					{
						Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result} - even");
					}
					else
					{
						Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result} - odd");
					}
				}
				else if (operation == '/')
				{
					Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result:f2}");
				}
				else if (operation == '%')
				{
					Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result}");
				}
			}
			else
			{
				Console.WriteLine($"Cannot divide {firstNumber} by zero");
			}

		}
	}
}
