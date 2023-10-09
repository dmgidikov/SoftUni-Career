using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Area_of_Figures
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string figureType = Console.ReadLine();

			if (figureType == "square")
			{
				double squareLenght = double.Parse(Console.ReadLine());
				Console.WriteLine(Math.Pow(squareLenght, 2));
			}
			else if (figureType == "rectangle")
			{
				double firstLenght = double.Parse(Console.ReadLine());
				double secondLenght = double.Parse(Console.ReadLine());
				Console.WriteLine(firstLenght * secondLenght);
			}
			else if (figureType == "circle")
			{
				double radius = double.Parse(Console.ReadLine());
				Console.WriteLine(Math.PI * Math.Pow(radius, 2));
			}
			else
			{
				double lenght = double.Parse(Console.ReadLine());
				double hight = double.Parse(Console.ReadLine());
				double result = (lenght * hight) / 2;
				Console.WriteLine(result);
			}
		}
	}
}
