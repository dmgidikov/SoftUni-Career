using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var regularGuests = new HashSet<string>();
            var vipGuests = new HashSet<string>();

            while (true)
            {
                var input = Console.ReadLine();
                var endWhoop = false;

                if (input == "PARTY")
                {
                    while (true)
                    {
                        var removeGuest = Console.ReadLine();

                        if (removeGuest == "END")
                        {
                            endWhoop = true;
                            break;
                        }

                        if (char.IsDigit(removeGuest[0]))
                        {
                            if (vipGuests.Contains(removeGuest))
                            {
                                vipGuests.Remove(removeGuest);
                            }
                        }
                        else
                        {
                            if (regularGuests.Contains(removeGuest))
                            {
                                regularGuests.Remove(removeGuest);
                            }
                        }

                    }
                }
                else
                {
                    if (input.Length == 8)
                    {
                        if (char.IsDigit(input[0]))
                        {
                            vipGuests.Add(input);
                        }
                        else
                        {
                            regularGuests.Add(input);
                        }
                    }
                }


                if (endWhoop == true)
                {
                    break;
                }
            }

            var totalNonGoingGuests = vipGuests.Count + regularGuests.Count;

            Console.WriteLine(totalNonGoingGuests);

            if (totalNonGoingGuests > 0)
            {
                if (vipGuests.Count > 0)
                {
                    foreach (var guest in vipGuests)
                    {
                        Console.WriteLine(guest);
                    }
                }

                if (regularGuests.Count > 0)
                {
                    foreach (var guest in regularGuests)
                    {
                        Console.WriteLine(guest);
                    }
                }
            }
        }
    }
}