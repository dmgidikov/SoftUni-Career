namespace SimpleSnake.Core
{
    using Enums;
    using System;
    using Constants;
    using GameObjects;
    using System.Threading;
    using GameObjects.Foods;
    using System.Collections.Generic;

    public class Engine
    {
        private const int SuspensionTime = 100;

        private Snake _snake;
        private int _gameScore;
        private Food _currentFood;
        private DrawManager _drawManager;
        private Coordinate _boardCoordinate;

        public Engine(DrawManager drawManager, Snake snake, Coordinate boardCoordinate)
        {
            _drawManager = drawManager;
            _snake = snake;
            _boardCoordinate = boardCoordinate;
            InitializeFood();
            InitializeBoarders();
        }

        public void Run()
        {
            while (true)
            {
                PlayerInfo();

                if (Console.KeyAvailable)
                {
                    SetNewDirection(Console.ReadKey());
                }

                _drawManager.Draw(_currentFood.FoodSymbol, new List<Coordinate>
                    {_currentFood.FoodCoordinate});

                _drawManager.Draw(GameConstants.Snake.Symbol, _snake.Body);

                _snake.Move();

                _drawManager.UndoDrawn();

                if (HasEatCollision())
                {
                    _snake.Eat(_currentFood);
                    _gameScore += _currentFood.FoodPoints;
                    InitializeFood();
                }

                if (HasBorderCollision())
                {
                    AskUserForRestart();
                }

                Thread.Sleep(SuspensionTime);
            }
        }

        private void SetNewDirection(ConsoleKeyInfo input)
        {
            var currentDirection = _snake.CurrentDirection;

            switch (input.Key)
            {
                case ConsoleKey.LeftArrow:
                    if (currentDirection != Direction.Right)
                    {
                        currentDirection = Direction.Left;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (currentDirection != Direction.Left)
                    {
                        currentDirection = Direction.Right;
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (currentDirection != Direction.Down)
                    {
                        currentDirection = Direction.Up;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (currentDirection != Direction.Up)
                    {
                        currentDirection = Direction.Down;
                    }
                    break;
            }

            _snake.CurrentDirection = currentDirection;
        }

        private bool HasEatCollision()
        {
            var headCoordinateX = _snake.Head.CoordinateX;
            var headCoordinateY = _snake.Head.CoordinateY;

            var foodCoordinateX = _currentFood.FoodCoordinate.CoordinateX;
            var foodCoordinateY = _currentFood.FoodCoordinate.CoordinateY;

            return headCoordinateX == foodCoordinateX &&
                   headCoordinateY == foodCoordinateY;
        }

        private bool HasBorderCollision()
        {
            var headCoordinateX = _snake.Head.CoordinateX;
            var headCoordinateY = _snake.Head.CoordinateY;

            var hasLeftBorderCollision =
                headCoordinateY <= 0 || headCoordinateY > GameConstants.Board.DefaultBoardHeight - 1;
            var hasTopBorderCollision =
                headCoordinateX <= 0 || headCoordinateX > GameConstants.Board.DefaultBoardHeight - 1;

            return hasLeftBorderCollision || hasTopBorderCollision;
        }

        private void InitializeFood()
        {
            _currentFood = FoodFactory.GenerateRandomFood(20, 20);
        }

        private void InitializeBoarders()
        {
            var allCoordinates = new List<Coordinate>();

            InitializeHorizontalBorder(0, allCoordinates);
            InitializeHorizontalBorder(GameConstants.Board.DefaultBoardHeight - 1,
                allCoordinates);
            InitializeVerticalBorder(0, allCoordinates);
            InitializeVerticalBorder(GameConstants.Board.DefaultBoardWidth,
                allCoordinates);

            _drawManager.Draw(GameConstants.Board.DefaultBorderSymbol, allCoordinates);
        }

        private void InitializeHorizontalBorder(int coordinateY, List<Coordinate> allCoordinates)
        {
            for (int coordinateX = 0; coordinateX < GameConstants.Board.DefaultBoardWidth; coordinateX++)
            {
                allCoordinates.Add(new Coordinate(coordinateX, coordinateY));
            }
        }

        private void InitializeVerticalBorder(int coordinateX, List<Coordinate> allCoordinates)
        {
            for (int i = 0; i < GameConstants.Board.DefaultBoardHeight; i++)
            {
                allCoordinates.Add(new Coordinate(coordinateX, i));
            }
        }

        private void PlayerInfo()
        {
            var x = GameConstants.Board.DefaultBoardWidth + GameConstants.Player.PlayerScoreOffsetX;
            var y = GameConstants.Player.PlayerScoreOffsetY;

            Console.SetCursorPosition(x, y);
            Console.Write($"Game score: {_gameScore}");
        }

        private void AskUserForRestart()
        {
            var x = 45;
            var y = 20;

            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Would you like to continue? ");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Y/N");

            var input = Console.ReadKey();

            if (input.Key != ConsoleKey.Y)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                StartUp.Main();
            }
        }
    }
}