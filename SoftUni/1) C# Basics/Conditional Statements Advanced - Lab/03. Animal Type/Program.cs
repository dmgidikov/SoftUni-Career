﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animal_Type
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string petType = Console.ReadLine();

			switch (petType)
			{
				case "dog":
				Console.WriteLine("mammal"); break;
				case "crocodile":
				case "tortoise":
				case "snake":
					Console.WriteLine("reptile"); break;				
				default:
					Console.WriteLine("unknown");
					break;
			}
		}
	}
}
