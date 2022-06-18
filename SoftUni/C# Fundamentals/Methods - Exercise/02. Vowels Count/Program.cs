using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vowels_Count
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string randomWord = Console.ReadLine().ToLower();

			int num = CheckForVowels(randomWord);
			PrintNumberOfVowels(num);
		}

		static void PrintNumberOfVowels(int result)
		{
			Console.WriteLine(result);
		}

		static int CheckForVowels(string word)
		{
			int counter = 0;

			for (int i = 0; i < word.Length; i++)
			{
				char symbol = word[i];

				if (symbol == 'a' || symbol == 'e' || symbol == 'o'
					|| symbol == 'u' || symbol == 'i')
				{
					counter++;
				}
			}

			return counter;
		}
	}
}
