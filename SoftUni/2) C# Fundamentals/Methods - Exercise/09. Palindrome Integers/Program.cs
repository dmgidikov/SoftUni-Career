using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Palindrome_Integers
{
	internal class Program
	{
		static void Main(string[] args)
		{	
			while (true)
			{
				string input = Console.ReadLine();

				if (input != "END")
				{
					int randomNum = int.Parse(input);
					int[] randomNums = new int[input.Length];
	
					for (int i = 0; i < input.Length; i++)
					{
						int current = randomNum % 10;
						randomNums[i] = current;
						randomNum /= 10;
					}
					
					int[] leftSide = new int[randomNums.Length / 2];
					int[] rightSide = new int[randomNums.Length / 2];
	
					for (int i = 0; i < leftSide.Length; i++)
					{
						leftSide[i] = randomNums[i];
					}
	
					for (int i = 0; i < rightSide.Length; i++)
					{
						rightSide[i] = randomNums[randomNums.Length - 1 - i];
					}
	
					rightSide.Reverse();

					bool Istrue = CheckPalindrom(leftSide, rightSide);
					Console.WriteLine(Istrue);
				}
				else
				{
					break;
				}
			}
		}
	
		static bool CheckPalindrom(int[] first, int[] second)
		{
			int counter = 0;
			for (int i = 0; i < first.Length; i++)
			{
				if (first[i] == second[i])
				{
					counter ++;
					break;					
				}
				else
				{
					counter--;
				}
			}

			if (counter > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
