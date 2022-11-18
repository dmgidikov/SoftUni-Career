﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _10.Crossroads
{
    internal class Program
    {
        static void Main()
        {
            int greenLightSeconds = int.Parse(Console.ReadLine());
            int secondsPassCrossroad = int.Parse(Console.ReadLine());

            Queue<string> carsQueue = new Queue<string>();

            int counter = 0;

            while (true)
            {
                string car = Console.ReadLine();

                int greenLights = greenLightSeconds;
                int passSeconds = secondsPassCrossroad;

                if (car == "END")
                {
                    Console.WriteLine($"Everyone is safe.{Environment.NewLine}" +
                        $"{counter} total cars passed the crossroads.");
                    return;
                }

                if (car == "green")
                {
                    while (greenLights > 0 && carsQueue.Any())
                    {

                        string firstInQueue = carsQueue.Dequeue();
                        greenLights -= firstInQueue.Count();
                        if (greenLights >= 0)
                        {
                            counter++;
                        }

                        else
                        {
                            passSeconds += greenLights;
                            if (passSeconds < 0)
                            {
                                Console.WriteLine($"A crash happened!{Environment.NewLine}" +
                                    $"{firstInQueue} was hit at" +
                                    $" {firstInQueue[firstInQueue.Length + passSeconds]}.");
                                return;
                            }
                            counter++;
                        }
                    }
                }

                else
                {
                    carsQueue.Enqueue(car);
                }
            }
        }
    }
}
