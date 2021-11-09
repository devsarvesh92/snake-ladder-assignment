using System;
using SnakeLadder.Core.GameAssets.Interfaces;
using SnakeLadder.Core.GamePlayer;

namespace SnakeLadder.Core.GameAssets
{
    public record Ladder(int bottomPosition, int topPosition, ConsoleColor ladderColor) : IPortal
    {
        /// <summary>
        /// Teleport simulates climb movement to the top of ladder
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public void Teleport(Player player) => player.Move(this.topPosition);

        public bool IsPresentAt(int location) => this.bottomPosition == location;
    }
}