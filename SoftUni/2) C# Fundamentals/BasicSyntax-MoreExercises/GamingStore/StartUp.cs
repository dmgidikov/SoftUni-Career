namespace GamingStore
{
    public class StartUp
    {
        public static void Main()
        {
            var validGames = new Dictionary<string, double>();

            validGames.Add("OutFall 4", 39.99);
            validGames.Add("CS: OG", 15.99);
            validGames.Add("Zplinter Zell", 19.99);
            validGames.Add("Honored 2", 59.99);
            validGames.Add("RoverWatch", 29.99);
            validGames.Add("RoverWatch Origins Edition", 39.99);

            var balance = double.Parse(Console.ReadLine());
            var totalSpend = 0d;

            while (true)
            {
                var game = Console.ReadLine();

                if (game == "Game Time")
                {
                    Console.WriteLine($"Total spent: ${totalSpend:f2}. Remaining: ${balance:f2}");
                    break;
                }
                else
                {
                    if (validGames.ContainsKey(game))
                    {
                        if (balance >= validGames[game])
                        {
                            Console.WriteLine($"Bought {game}");
                            totalSpend += validGames[game];
                            balance -= validGames[game];
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not Found");
                    }

                    if (balance == 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                }                
            }
        }
    }
}
