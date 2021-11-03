using System;
using SnakeLadder.Core.GamePlayer;

namespace SnakeLadder.Core.GameAssets
{
    public record Snake(int headStart, int tailEnd, ConsoleColor snakeColor)
    {
        /// <summary>
        /// Bite moves player to the tailEnd
        /// </summary>
        public void Bite(Player player) => player.Move(this.tailEnd);
    };
}
