using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Password_Validator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string randomWord = Console.ReadLine().ToLower();

			int checkForLenght = randomWord.Length;
			int countForTwoDigits = 0;
			int checkType = 0;

			for (int i = 0; i < randomWord.Length; i++)
			{
				if (!(char.IsLetterOrDigit(randomWord[i])))
				{
					checkType++;
				}

				if (char.IsDigit(randomWord[i]))
				{
					countForTwoDigits++;
				}
			}

			if (checkForLenght >= 6 && checkForLenght <= 10 && countForTwoDigits > 1 && checkType == 0)
			{
				PrintValidPassword();
			}
			else
			{
				PrintForLenght(checkForLenght);
				PrintForLettersAndDigits(checkType);
				PrintForDigits(countForTwoDigits);
			}
		}

		static void PrintForLenght(int lenght)
		{
			if (!(lenght >= 6 && lenght <= 10))
			{
				Console.WriteLine("Password must be between 6 and 10 characters");
			}
		}

		static void PrintForDigits(int digits)
		{
			if (digits < 2) 
			{
				Console.WriteLine("Password must have at least 2 digits");
			}
		}

		static void PrintForLettersAndDigits(int num)
		{
			if (num != 0)
			{
				Console.WriteLine("Password must consist only of letters and digits");				
			}
		}

		static void PrintValidPassword()
		{
			Console.WriteLine("Password is valid");
		}
	}
}
