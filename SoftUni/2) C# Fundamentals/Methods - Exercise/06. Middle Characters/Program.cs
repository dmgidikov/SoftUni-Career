using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Middle_Characters
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string randomWord = Console.ReadLine();

			string result = string.Empty;


			if (randomWord.Length % 2 == 0)
			{
				result += randomWord[randomWord.Length / 2 - 1];
				result += randomWord[randomWord.Length / 2];
			}
			else
			{
				result += randomWord[randomWord.Length / 2];
			}

			PrintResult(result);
		}

		static void PrintResult(string result)
		{
			Console.WriteLine(result);
		}
	}
}
