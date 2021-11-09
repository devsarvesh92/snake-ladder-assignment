using System;
using SnakeLadder.Core.GameAssets.Interfaces;
using SnakeLadder.Core.GamePlayer;

namespace SnakeLadder.Core.GameAssets
{
    public record Snake(int headStart, int tailEnd) : IPortal
    {

        /// <summary>
        /// Teleport simulates bite movement to the tailEnd
        /// </summary>
        public void Teleport(Player player) => player.Move(this.tailEnd);

        public bool IsPresentAt(int location) => this.headStart == location;
    }
}