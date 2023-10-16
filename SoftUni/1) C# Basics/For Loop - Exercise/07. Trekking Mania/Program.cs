using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Trekking_Mania
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int inputNumebr = int.Parse(Console.ReadLine());

			double trekkingMusala = 0;
			double trekkingMonblan = 0;
			double trekkingKilimandjaro = 0;
			double trekkingK2 = 0;
			double trekkingEverest = 0;

			for (int i = 0; i < inputNumebr; i++)
			{
				int group = int.Parse(Console.ReadLine());

				if (group <= 5)
				{
					trekkingMusala += group;
				}
				else if (group > 5 && group <= 12)
				{
					trekkingMonblan+= group;
				}
				else if (group > 12 && group <= 25)
				{
					trekkingKilimandjaro += group;
				}
				else if (group > 25 && group <= 40)
				{
					trekkingK2 += group;
				}
				else
				{
					trekkingEverest += group;
				}
			}

			double totalPeople = trekkingMusala + trekkingMonblan + 
				trekkingKilimandjaro + trekkingEverest + trekkingK2;

			double resultMusala = (trekkingMusala * 100) / totalPeople;
			double resultMonblan = (trekkingMonblan * 100) / totalPeople;
			double resultKilimandjaro = (trekkingKilimandjaro * 100) / totalPeople;
			double resultK2 = (trekkingK2 * 100) / totalPeople;
			double resultEverest = (trekkingEverest * 100) / totalPeople;

			Console.WriteLine($"{resultMusala:f2}%");
			Console.WriteLine($"{resultMonblan:f2}%");
			Console.WriteLine($"{resultKilimandjaro:f2}%");
			Console.WriteLine($"{resultK2:f2}%");
			Console.WriteLine($"{resultEverest:f2}%");

		}
	}
}
