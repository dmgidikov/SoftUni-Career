using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Rage_Expenses
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int counterLostGames = int.Parse(Console.ReadLine());
			double headsetPrice = double.Parse(Console.ReadLine());
			double mousePrice = double.Parse(Console.ReadLine());
			double keyboardPrice = double.Parse(Console.ReadLine());
			double displeyPrice = double.Parse(Console.ReadLine());

			int counterBrokenHeadset = 0;
			int counterBrokenMouse = 0;
			int counterBrokenKeyboard = 0;

			for (int i = 1; i <= counterLostGames; i++)
			{
				if (i % 2 == 0 && i % 3 == 0)
				{
					counterBrokenHeadset++;
					counterBrokenMouse++;
					counterBrokenKeyboard++;
				}
				else if (i % 3 == 0)
				{
					counterBrokenMouse++;
				}
				else if (i % 2 == 0)
				{
					counterBrokenHeadset++;
				}				
			}

			int counterBrokenDisplay = counterBrokenKeyboard / 2;

			double moneyForHeadset = headsetPrice * counterBrokenHeadset;
			double moneyForMouse = mousePrice * counterBrokenMouse; 
			double moneyForKeyboard = keyboardPrice * counterBrokenKeyboard; 
			double moneyFoDispley = displeyPrice * counterBrokenDisplay;

			double sum = moneyForHeadset + moneyForMouse + moneyForKeyboard + moneyFoDispley;

			Console.WriteLine($"Rage expenses: {sum:f2} lv.");
		}
	}
}
