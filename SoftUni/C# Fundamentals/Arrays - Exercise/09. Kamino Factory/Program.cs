using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Kamino_Factory
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int randomNumber = int.Parse(Console.ReadLine());

			int[] lowValueArray = new int[randomNumber];

			for (int i = 0; i < lowValueArray.Length; i++)
			{
				lowValueArray[i] = 0;
			}

			int sumOfOnesInArray = lowValueArray.Sum();
			int counter = 0;
			int index = 0;
			int bestDnaNumber = 0;

			while (true)
			{
				string randomString = Console.ReadLine();

				if (randomString != "Clone them!")
				{
					int[] randomNumbers = randomString.Split('!')
						.Select(int.Parse).ToArray();

					int currentCounter = 0;
					int currentIndex = 0;
					int currentSumOfOnesInArray = randomNumbers.Sum();					

					for (int i = 0; i < randomNumbers.Length - 1; i++)
					{
						int currentNum = randomNumbers[i];
						int nextNum = randomNumbers[i + 1];

						if (currentNum == 1 && nextNum == 1)
						{
							currentCounter++;
							currentIndex = i;							
						}
					}

					if (randomNumbers[randomNumbers.Length - 2] == 1 &&
						randomNumbers[randomNumbers.Length - 1] == 1)
					{
						currentCounter++;
					}


					if (currentCounter > counter)
					{
						for (int i = 0; i < lowValueArray.Length; i++)
						{
							lowValueArray[i] = randomNumbers[i];
						}
						counter = currentCounter;
						index = currentIndex;
						bestDnaNumber++;
						sumOfOnesInArray = currentSumOfOnesInArray;
					}
					else
					{
						if (currentCounter == counter && currentIndex == index)
						{
							if (currentSumOfOnesInArray > sumOfOnesInArray)
							{
								for (int i = 0; i < lowValueArray.Length; i++)
								{
									lowValueArray[i] = randomNumbers[i];
								}
								bestDnaNumber++;
								sumOfOnesInArray = currentSumOfOnesInArray;
							}

						}
						else if (currentCounter == counter)
						{
							if (currentIndex < index)
							{
								for (int i = 0; i < lowValueArray.Length; i++)
								{
									lowValueArray[i] = randomNumbers[i];
								}
								index = currentIndex;
							bestDnaNumber++;
							sumOfOnesInArray = currentSumOfOnesInArray;
							}
						}
					}		
				}
				else
				{
					Console.WriteLine($"Best DNA sample {bestDnaNumber} with sum: {sumOfOnesInArray}.");

					foreach (int number in lowValueArray)
					{
						Console.Write(number + " ");
					}
					break;
				}
			}
		}
	}
}
