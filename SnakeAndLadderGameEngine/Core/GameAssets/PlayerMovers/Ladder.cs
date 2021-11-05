using System;
using SnakeLadder.Core.GameAssets.PlayerMovers.Interfaces;
using SnakeLadder.Core.GamePlayer;

namespace SnakeLadder.Core.GameAssets.PlayerMovers
{
    public record Ladder(int bottomPosition, int topPosition, ConsoleColor ladderColor) : IPlayerMover
    {
        /// <summary>
        /// MovePlayer simulates climb movement to the top of ladder
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public void MovePlayer(Player player) => player.Move(this.topPosition);
    }
}