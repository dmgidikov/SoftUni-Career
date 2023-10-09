using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Login
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string username = Console.ReadLine();

			string password = string.Empty;

			for (int i = username.Length - 1; i >= 0; i--) 
			{
				char currentChar = username[i];
				password += currentChar;
			}

			int counter = 0;

			while (true)
			{
				string input = Console.ReadLine();

				if (input == password)
				{
					Console.WriteLine($"User {username} logged in.");
					break;
				}
				else
				{
					if (counter == 3)
					{
						Console.WriteLine($"User {username} blocked!");
						break;
					}
					else
					{
						Console.WriteLine("Incorrect password. Try again.");
						counter++;
					}
				}
			}
		}
	}
}
