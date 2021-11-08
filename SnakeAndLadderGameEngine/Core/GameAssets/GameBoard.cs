using System.Collections.Generic;
using System.Linq;
using SnakeLadder.Core.GameAssets.Interfaces;

namespace SnakeLadder.Core.GameAssets
{
    public record GameBoard(int Width, int Height)
    {
        public int Destination = Width * Height;

        public readonly List<Snake> Snakes = GetSnakes();

        public readonly List<Ladder> Ladders = GetLadders();

        /// <summary>
        /// Playermovables present at player location
        /// Playermovables = Either snake or ladder because they moves player from Source to destination
        /// </summary>
        /// <param name="location"></param>
        /// <returns>Playermovables</returns>
        public IPortal GetPlayerMovables(int location)
        {
            IPortal playerMovable;

            playerMovable = this.Snakes.FirstOrDefault(snake => snake.headStart == location);

            if (playerMovable == null)
            {
                playerMovable = this.Ladders.FirstOrDefault(ladder => ladder.bottomPosition == location);
            }

            return playerMovable;
        }

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
