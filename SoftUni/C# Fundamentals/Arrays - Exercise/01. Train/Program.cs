using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Train
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int randomNumber = int.Parse(Console.ReadLine());

			int[] numbers = new int[randomNumber];

			int sum = 0;

			for (int i = 0; i < numbers.Length; i++)
			{
				numbers[i] = int.Parse(Console.ReadLine());
				sum+= numbers[i];
			}
			
			Console.Write(string.Join(" ", numbers));
			Console.WriteLine();
			Console.WriteLine(sum);

		}
	}
}
