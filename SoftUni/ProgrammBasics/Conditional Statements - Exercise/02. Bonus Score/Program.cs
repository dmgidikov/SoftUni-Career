using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bonus_Score
{
	internal class Program
	{ 
		static void Main(string[] args)
		{
			int randomEvenNumber = int.Parse(Console.ReadLine());

			double bonusPoints = 0;

			if (randomEvenNumber > 1000)
			{
				bonusPoints = randomEvenNumber * 0.1;
			}
			else if (randomEvenNumber > 100)
			{
				bonusPoints = randomEvenNumber * 0.2;
			}
			else
			{
				bonusPoints = 5;
			}

			if (randomEvenNumber % 2 == 0)
				bonusPoints++;

			if (randomEvenNumber % 10 == 5)
				bonusPoints += 2;

			Console.WriteLine(bonusPoints);
			Console.WriteLine(randomEvenNumber + bonusPoints);
		}
	}

}