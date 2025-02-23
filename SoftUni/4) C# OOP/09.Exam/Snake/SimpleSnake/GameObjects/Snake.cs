namespace SimpleSnake.GameObjects
{
    using Enums;
    using Foods;
    using Constants;
    using System.Linq;
    using System.Collections.Generic;

    public class Snake
    {
        private readonly List<Coordinate> _snakeBody;

        public Snake()
        {
            _snakeBody = new List<Coordinate>();
            InitializeBody();
            CurrentDirection = Direction.Right;
        }

        public Direction CurrentDirection { get; set; }

        public IReadOnlyCollection<Coordinate> Body => _snakeBody.AsReadOnly();

        public Coordinate Head => _snakeBody.Last();

        public void Move()
        {
            var currentHead = _snakeBody.Last();

            var newHeadCoordinate = CalculateNewCoordinate(
                new Coordinate(currentHead.CoordinateX, currentHead.CoordinateX));

            _snakeBody.Add(newHeadCoordinate);
            _snakeBody.RemoveAt(0);
        }

        public void Eat(Food food)
        {
            for (int i = 0; i < food.FoodPoints; i++)
            {
                var coordinate = CalculateNewCoordinate(Head);
                _snakeBody.Add(coordinate);
            }
        }

        private void InitializeBody()
        {
            var x = GameConstants.Snake.DefaultCoordinateX;
            var y = GameConstants.Snake.DefaultCoordinateY;

            for (int i = 0; i < GameConstants.Snake.DefaultLength; i++)
            {
                _snakeBody.Add(new Coordinate(x, y));
                x++;
            }
        }

        private Coordinate CalculateNewCoordinate(Coordinate coordinate)
        {
            switch (CurrentDirection)
            {
                case Direction.Right:
                    coordinate.CoordinateX += 1;
                    break;
                case Direction.Left:
                    coordinate.CoordinateX -= 1;
                    break;
                case Direction.Down:
                    coordinate.CoordinateY += 1;
                    break;
                case Direction.Up:
                    coordinate.CoordinateY -= 1;
                    break;
            }

            return coordinate;
        }
    }
}