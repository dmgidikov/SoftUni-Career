﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchesToCentimeters
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double inches = double.Parse(Console.ReadLine());
			double b = 2.54;

			Console.WriteLine(inches * b);
		}
	}
}
