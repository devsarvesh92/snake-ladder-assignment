using System;
using SnakeLadder.Core.GameAssets.Interfaces;
using SnakeLadder.Core.GamePlayer;

namespace SnakeLadder.Core.GameAssets
{
    public record Ladder(int bottomPosition, int topPosition) : IPortal
    {
        public void Teleport(Player player) => player.Move(this.topPosition);

        public bool IsPresentAt(int location) => this.bottomPosition == location;

        public (int start, int end) GetLocation() => (bottomPosition, topPosition);
    }
}