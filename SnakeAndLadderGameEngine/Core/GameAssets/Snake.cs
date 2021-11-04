using System;
using SnakeLadder.Core.GamePlayer;

namespace SnakeLadder.Core.GameAssets
{
    public record Snake(int headStart, int tailEnd, ConsoleColor snakeColor) : IMovable
    {
        /// <summary>
        /// MovePlayer simulates bite movement to the tailEnd
        /// </summary>
        public void MovePlayer(Player player) => player.Move(this.tailEnd);
    }
}
