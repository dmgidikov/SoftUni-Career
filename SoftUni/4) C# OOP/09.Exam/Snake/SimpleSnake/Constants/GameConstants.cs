﻿namespace SimpleSnake.Constants
{
    public static class GameConstants
    {
        public static class Snake
        {
            public static readonly string Symbol = @"\u25CF";
            public static readonly int DefaultLength = 6;
            public static readonly int DefaultCoordinateX = 5;
            public static readonly int DefaultCoordinateY = 6;
        }

        public static class Food
        {
            public static readonly string SymbolAsterisk = "*";
            public static readonly int AsteriskPoints = 1;
            public static readonly string SymbolDollar = "$";
            public static readonly int DollarPoints = 2;
            public static readonly string SymbolHash = "#";
            public static readonly int HashPoints = 3;
        }

        public static class Board
        {
            public static readonly int DefaultBoardWidth = 120;
            public static readonly int DefaultBoardHeight = 40;
            public static readonly string DefaultBorderSymbol = @"\u25A0";
        }

        public static class Player
        {
            public static readonly int PlayerScoreOffsetX = 10;
            public static readonly int PlayerScoreOffsetY = 10;
        }

        public static class Config
        {
            public static readonly int DefaultWindowWidth = 200;
            public static readonly int DefaultWindowHeight = 50;
            public static readonly int DefaultFPS = 100;
        }
    }
}