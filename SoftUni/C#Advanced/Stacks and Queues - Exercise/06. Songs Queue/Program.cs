using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _06.Songs_Queue
{
    internal class Program
    {
        static void Main()
        {
            var firstSongs = Console.ReadLine().Split(", ");

            var myAlbum = new Queue<string>(firstSongs);

            while (true)
            {
                if (myAlbum.Any())
                {
                    var command = Console.ReadLine().Split();

                    if (command[0] == "Play")
                    {
                        myAlbum.Dequeue();
                    }
                    else if (command[0] == "Show")
                    {
                        Console.WriteLine(string.Join(", ", myAlbum));
                    }
                    else
                    {
                        var songToBeAdded = string.Empty;

                        for (int i = 1; i < command.Length; i++)
                        {
                            var current = command[i];
                            songToBeAdded+= current + " ";
                        }

                        songToBeAdded = songToBeAdded.Trim();

                        if (myAlbum.Contains(songToBeAdded) == false)
                        {
                            myAlbum.Enqueue(songToBeAdded);
                        }
                        else
                        {
                            Console.WriteLine($"{songToBeAdded} is already contained!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No more songs!");
                    break;
                }
               
            }
        }
    }
}
