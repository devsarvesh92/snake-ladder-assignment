using System.Collections.Generic;
using System.Linq;

namespace SnakeLadder.Core.GameAssets
{
    public record GameBoard(int Width, int Height)
    {
        public int Destination = Width * Height;

        public readonly List<Snake> Snakes = GetSnakes();

        public readonly List<Ladder> Ladders = GetLadders();

        public Snake GetSnake(int location) => Snakes.FirstOrDefault(snake => snake.tailEnd == location);

        private static List<Snake> GetSnakes()
        {
            return new List<Snake>()
            {
                new Snake(14,7,System.ConsoleColor.Blue)
            };
        }

        private static List<Ladder> GetLadders()
        {
            return new List<Ladder>()
            {
                new Ladder(2,23,System.ConsoleColor.DarkYellow),
                new Ladder(8,24,System.ConsoleColor.Red),
                new Ladder(9,81,System.ConsoleColor.Green),
                new Ladder(29,65,System.ConsoleColor.Yellow),
                new Ladder(69,96,System.ConsoleColor.DarkMagenta)
            };
        }
    }
}
