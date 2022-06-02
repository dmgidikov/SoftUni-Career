using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Character_Sequence
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string randomString = Console.ReadLine();

			for (int i = 0; i < randomString.Length; i++)
			{
				char currentChar = randomString[i];
				Console.WriteLine(currentChar);
			}
		}
	}
}
