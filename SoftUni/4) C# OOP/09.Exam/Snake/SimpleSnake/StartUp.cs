namespace SimpleSnake
{
    using Core;
    using Constants;
    using Utilities;
    using GameObjects;

    public class StartUp
    {
        public static void Main()
        {
            ConsoleWindow.CustomizeConsole();

            var drawManager = new DrawManager();
            var snake = new Snake();

            var boardCoordinate = new Coordinate(
                GameConstants.Board.DefaultBoardWidth, 
                GameConstants.Board.DefaultBoardHeight);

            var engine = new Engine(drawManager, snake, boardCoordinate);
            engine.Run();
        }
    }
}