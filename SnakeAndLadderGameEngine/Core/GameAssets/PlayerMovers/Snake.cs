using System;
using SnakeLadder.Core.GameAssets.PlayerMovers.Interfaces;
using SnakeLadder.Core.GamePlayer;

namespace SnakeLadder.Core.GameAssets.PlayerMovers
{
    public record Snake(int headStart, int tailEnd, ConsoleColor snakeColor) : IPlayerMover
    {
        /// <summary>
        /// MovePlayer simulates bite movement to the tailEnd
        /// </summary>
        public void MovePlayer(Player player) => player.Move(this.tailEnd);
    }
}