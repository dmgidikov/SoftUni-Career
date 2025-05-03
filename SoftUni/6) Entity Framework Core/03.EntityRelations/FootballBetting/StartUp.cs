namespace FootballBetting
{
    using Data;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new FootballBettingContext();
        }
    }
}