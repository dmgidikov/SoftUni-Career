using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Reverse_Array_of_Strings
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] randomElements = Console.ReadLine().Split();

			for (int i = 0; i < randomElements.Length / 2; i++)
			{
				string firstElement = randomElements[i];
				string lastElement = randomElements[randomElements.Length - i - 1];

				randomElements[randomElements.Length - i - 1] = firstElement;
				randomElements[i] = lastElement ;
			}

			for (int i = 0; i < randomElements.Length; i++)
			{
				Console.Write(randomElements[i] + " ");
			}
		}
	}
}
