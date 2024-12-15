namespace _05.FootballTeamGenerator
{
    using Common;
    using Models;

    public class StartUp
    {
        public static void Main()
        {
            var teams = new List<Team>();

            try
            {
                while (true)
                {
                    var input = Console.ReadLine();

                    if (input == "END")
                    {
                        break;
                    }

                    var args = input.Split(";");

                    var teamName = args[1];

                    if (args[0] == "Team")
                    {
                        var team = new Team(teamName);
                        teams.Add(team);
                    }
                    else if (args[0] == "Add")
                    {
                        var player = CreatePlayer(args);

                        foreach (var team in teams)
                        {
                            if (team.Name == teamName)
                            {
                                team.AddPlayer(player);
                            }
                        }
                    }
                    else if (args[0] == "Remove")
                    {
                        var playerToRemove = args[2];

                        foreach (var team in teams)
                        {
                            if (team.Players.Any(x => x.Name == playerToRemove))
                            {
                                var player = team.Players.First(x => x.Name == playerToRemove);
                                team.RemovePlayer(player);
                            }
                        }
                    }
                    else if (args[0] == "Rating")
                    {
                        var team = teams.First(x => x.Name == teamName);
                        Console.WriteLine(team.Rating);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }           

        private static Player CreatePlayer(string[] args)
        {
            var playerName = args[2];
            var endurance = int.Parse(args[3]);
            var sprint = int.Parse(args[4]);
            var dribble = int.Parse(args[5]);
            var passing = int.Parse(args[6]);
            var shooting = int.Parse(args[7]);

            var player = new Player(playerName, endurance,
                sprint, dribble, passing, shooting);
            return player;
        }
    }
}