using System;
using SnakeLadder.Core.GamePlayer;

namespace SnakeLadder.Core.GameAssets
{
    public record Ladder(int bottomPosition, int topPosition, ConsoleColor ladderColor) : IMovable
    {
        /// <summary>
        /// MovePlayer simulates climb movement to the top of ladder
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public void MovePlayer(Player player) => player.Move(this.topPosition);
    }
}