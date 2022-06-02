﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Time___15_Minutes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int hours = int.Parse(Console.ReadLine());
			int minutes = int.Parse(Console.ReadLine()) + 15;

			if (minutes > 59)
			{
				hours++;
				minutes %= 60;
			}
			if (hours > 23)
			{
				hours = 0;
			}

			Console.WriteLine($"{hours}:{minutes:d2}");
		}
	}
}
