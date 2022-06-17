using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Greater_of_Two_Values
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string tempType = Console.ReadLine();

			switch (tempType)
			{
				case "int": 
					int firstInt = int.Parse(Console.ReadLine());
					int secondInt = int.Parse(Console.ReadLine());
					int resultAsInt = GetBiggerInt(firstInt, secondInt);
					Console.WriteLine(resultAsInt);
					break;

				case "string":
					string firstString = Console.ReadLine();
					string secondString = Console.ReadLine();
					string resultAsString = GetBiggerString(firstString, secondString);
					Console.WriteLine(resultAsString);
					break;

				case "char":
					char firstChar = char.Parse(Console.ReadLine());
					char secondChar = char.Parse(Console.ReadLine());
					char resultAsChar = GetBiggerChar(firstChar, secondChar);
					Console.WriteLine(resultAsChar);
					break;
			}
		}

		static string GetBiggerString(string firstElement, string secondElement)
		{
			if (string.Compare(firstElement, secondElement) > 0)
			{
				return firstElement;
			}
			else
			{
				return secondElement;
			}
		}

		static int GetBiggerInt(int first, int second)
		{
			int result = Math.Max(first, second);
			return result;
		}

		static char GetBiggerChar(char first, char second)
		{
			char result = (char)Math.Max(first, second);
			return result;
		}
	}
}
