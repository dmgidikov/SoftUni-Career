using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Repeat_String
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string randomString = Console.ReadLine();
			int repeatingTimes = int.Parse(Console.ReadLine());

			string result = PrintString(randomString, repeatingTimes);
			Console.WriteLine(result);
		}

		static string PrintString(string text, int number)
		{
			string result = string.Empty;

			for (int i = 0; i < number; i++)
			{
				result += text;				
			}

			return result;
		}
	}
}
