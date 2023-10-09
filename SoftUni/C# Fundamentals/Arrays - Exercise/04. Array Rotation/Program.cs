using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Array_Rotation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] randomArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int randomNumber = int.Parse(Console.ReadLine());

			for (int i = 0; i < randomNumber; i++)
			{
				int firstElement = randomArray[0];

				for (int j = 1; j < randomArray.Length; j++)
				{
					int currentElement = randomArray[j];
					randomArray[j - 1] = currentElement;
				}				
					randomArray[randomArray.Length-1] = firstElement;
			}

			Console.WriteLine(String.Join(" ", randomArray));
		}
	}
}
