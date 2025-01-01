namespace _7.MilitaryElite
{
    using _7.MilitaryElite.IO;
    using Core;

    public class StartUp
    {
        public static void Main()
        {
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();

            var engine = new Engine(reader, writer);
            engine.Run();
        }
    }
}