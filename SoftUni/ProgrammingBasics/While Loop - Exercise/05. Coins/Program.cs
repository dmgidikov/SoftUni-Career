using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Coins
{
	internal class Program
	{
		static void Main(string[] args)
		{
			decimal input = decimal.Parse(Console.ReadLine());

			int tokens = 0;

			int leva = (int)input;
			int cent = (int)((decimal)(input - leva) * 100);

			while (true)
			{			
				if (leva >= 2)
				{
					tokens++;
					leva -= 2;
				}
				else if (leva == 1)
				{
					tokens++;
					leva -= 1;
				}else
				break;
			}
			
			while (true)
			{
				if (cent >= 50)
				{
					cent -= 50;
					tokens++;
				}
				else if (cent >= 20)
				{
					cent -= 20;
					tokens++;
				}
				else if (cent >= 10)
				{
					cent -= 10;
					tokens++;
				}
				else if (cent >= 5)
				{
					cent -= 5;
					tokens++;
				}
				else if (cent >= 2)
				{
					cent -= 2;
					tokens++;
				}
				else if (cent >= 1)
				{
					cent -= 1;
					tokens++;
				}
				else
					break;
			}

			Console.WriteLine(tokens);
		}
	}
}
