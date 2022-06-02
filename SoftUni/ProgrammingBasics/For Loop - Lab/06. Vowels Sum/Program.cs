using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Vowels_Sum
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string randomWord = Console.ReadLine();

			double counter = 0;

			for (int i = 0; i < randomWord.Length; i++)
			{
				char currentChar = randomWord[i];

				switch (currentChar)
				{
					case 'a': counter += 1; break;
					case 'e': counter += 2; break;
					case 'i': counter += 3; break;
					case 'o': counter += 4; break;
					case 'u': counter += 5; break;

					default:
						break;
				}
			}

			Console.WriteLine(counter);
		}
	}
}
