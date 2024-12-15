namespace _05.FootballTeamGenerator.Common
{
    public static class GlobalExceptions
    {
        public static string InvalidName =
            "A name should not be empty.";

        public static string InvalidPlayerStat =
            "{0} should be between 0 and 100.";

        public static string MissingPlayer =
            "Player {0} is not in {1} team.";

        public static string MissingTeam =
            "Team {0} does not exist.";
    }
}