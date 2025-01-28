namespace CommandPattern
{
    using Core;
    using Models;

    public class StartUp
    {
        public static void Main()
        {
            var command = new CommandInterpreter();
            var engine = new Engine(command);
            engine.Run();
        }
    }
}