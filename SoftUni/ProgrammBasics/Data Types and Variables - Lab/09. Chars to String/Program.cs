﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Chars_to_String
{
	internal class Program
	{
		static void Main(string[] args)
		{
			char firstChar = char.Parse(Console.ReadLine());
			char secondChar = char.Parse(Console.ReadLine());
			char thirdChar = char.Parse(Console.ReadLine());

			string totalString = firstChar.ToString() + secondChar.ToString() + thirdChar.ToString();
			Console.WriteLine(totalString);
		}
	}
}
