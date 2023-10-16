using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Common_Elements
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] firstArray = Console.ReadLine().Split();
			string[] secondArray = Console.ReadLine().Split();

			for (int i = 0; i < secondArray.Length; i++)
			{
				string stringFromSecondArray = secondArray[i];

				for (int j = 0; j < firstArray.Length; j++)
				{
					string stringFromFirstArray = firstArray[j];

					if (stringFromSecondArray == stringFromFirstArray)
						Console.Write(stringFromSecondArray + " ");
				}
			}
			Console.WriteLine();
		}
	}
}
