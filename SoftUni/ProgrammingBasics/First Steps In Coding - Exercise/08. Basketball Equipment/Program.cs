using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08BasketballEquipment
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int yearlyTax = int.Parse(Console.ReadLine());

			double basketballShoes = yearlyTax - (yearlyTax * 0.4);
			double basketballSuit = basketballShoes - (basketballShoes * 0.2);
			double basketballBall = basketballSuit * 0.25;
			double basketballAccesoaris = basketballBall * 0.2;

			double totalSpent = yearlyTax + basketballShoes + basketballSuit + basketballBall + basketballAccesoaris;
			Console.WriteLine(totalSpent);

		}
	}
}
