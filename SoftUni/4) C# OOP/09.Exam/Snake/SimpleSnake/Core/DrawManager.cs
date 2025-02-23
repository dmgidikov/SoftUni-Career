namespace SimpleSnake.Core
{
    using System;
    using Constants;
    using System.Linq;
    using GameObjects;
    using System.Collections.Generic;

    public class DrawManager
    {
        private readonly List<Coordinate> _lastDrawnElements = new();

        public void Draw(string symbol, IReadOnlyCollection<Coordinate> coordinates)
        {
            foreach (var coordinate in coordinates)
            {
                if (symbol == GameConstants.Snake.Symbol)
                {
                    _lastDrawnElements.Add(coordinate);
                }

                DrawOperation(symbol, coordinate);
            }
        }

        public void UndoDrawn()
        {
            if (!_lastDrawnElements.Any()) return;
            DrawOperation(" ", _lastDrawnElements.First());
            _lastDrawnElements.Clear();
        }

        private void DrawOperation(string symbol, Coordinate coordinate)
        {
            Console.SetCursorPosition(coordinate.CoordinateX, coordinate.CoordinateY);
            Console.WriteLine(symbol);
        }
    }
}