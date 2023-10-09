using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _8.Traffic_Jam
{
    internal class Program
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            var qeueu = new Queue<string>();
            var passedCars = 0;

            while (true)
            {
                var name = Console.ReadLine();

                if (name == "end")
                {
                    Console.WriteLine($"{passedCars} cars passed the crossroads.");
                    break;
                }
                else if (name == "green")
                {
                    int count = 0;

                    while(qeueu.Any())
                    {
                        if (count == num)
                        {
                            break;
                        }
                        else
                        {
                            var passCar = qeueu.Dequeue();

                            Console.WriteLine($"{passCar} passed!");

                            count++;
                            passedCars++;
                        }
                    }
                }
                else
                {
                    qeueu.Enqueue(name);
                }
            }
        }
    }
}
