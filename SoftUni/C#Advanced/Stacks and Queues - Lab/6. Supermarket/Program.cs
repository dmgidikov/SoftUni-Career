using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _6.Supermarket
{
    internal class Program
    {
        static void Main()
        {
            var ramainingPeople = new Queue<string>();

            while (true)
            {
                var name = Console.ReadLine();

                if (name == "End")
                {
                    Console.WriteLine($"{ramainingPeople.Count} people remaining.");
                    break;
                }
                else if (name == "Paid")
                {
                    while (ramainingPeople.Any())
                    {
                        var person = ramainingPeople.Dequeue();
                        Console.WriteLine(person);
                    }
                }
                else
                {
                    ramainingPeople.Enqueue(name);
                }
            }
        }
    }
}
