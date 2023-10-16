using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Reverse_String
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string randomString = Console.ReadLine();

			string reversString = string.Empty;

			for (int i = randomString.Length - 1; i >= 0; i--)
			{
				char symbol = randomString[i];
				reversString += symbol;
			}

			Console.WriteLine(reversString);
		}
	}
}
