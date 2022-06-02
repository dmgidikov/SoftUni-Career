using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Personal_Titles
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double randomNumber = double.Parse(Console.ReadLine());
			char gender = char.Parse(Console.ReadLine());

			if (gender == 'm')
			{
				if (randomNumber >= 16)
				{
					Console.WriteLine("Mr.");
				}
				else
				{
					Console.WriteLine("Master");
				}
			}
			else
			{
				if (randomNumber >= 16)
				{
					Console.WriteLine("Ms.");
				}
				else
				{
					Console.WriteLine("Miss");
				}
			}
		}
	}
}
