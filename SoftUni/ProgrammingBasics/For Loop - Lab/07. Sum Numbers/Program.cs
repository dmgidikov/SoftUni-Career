using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Numbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int numberOfInputs = int.Parse(Console.ReadLine());

			int sum = 0;

			for (int i = 0; i < numberOfInputs; i++)
			{
				int currentInput = int.Parse(Console.ReadLine());
				sum += currentInput;
			}

			Console.WriteLine(sum);
		}
	}
}
