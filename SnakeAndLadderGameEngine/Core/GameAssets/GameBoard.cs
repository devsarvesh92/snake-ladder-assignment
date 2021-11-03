using System.Collections.Generic;
using System.Linq;

namespace SnakeLadder.Core.GameAssets
{
    public record GameBoard(int Width, int Height)
    {
        public int Destination = Width * Height;
        
        public readonly List<Snake> Snakes = GetSnakes();

        public Snake GetSnake(int location) => Snakes.FirstOrDefault(snake => snake.tailEnd == location);

        private static List<Snake> GetSnakes()
        {
            return new List<Snake>()
            {
                new Snake(14,7)
            };
        }
    }
}
