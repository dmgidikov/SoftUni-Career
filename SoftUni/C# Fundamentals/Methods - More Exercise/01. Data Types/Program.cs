using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Data_Types
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string command = Console.ReadLine().ToLower();
			string input = Console.ReadLine();

			PrintElement(command, input);
		}

		static void PrintElement(string command, string input)
		{
			if (command == "string")
			{
				Console.WriteLine($"${input}$");
			}
			else if (command == "int")
			{
				int temp = int.Parse(input);
				Console.WriteLine(temp * 2);
			}
			else
			{
				double temp = double.Parse(input);
				double result = temp * 1.5;
				Console.WriteLine($"{result:f2}");
			}
		}
	}
}
