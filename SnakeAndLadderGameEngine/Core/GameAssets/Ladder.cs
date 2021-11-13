using System;
using SnakeLadder.Core.GameAssets.Interfaces;
using SnakeLadder.Core.GamePlayer;

namespace SnakeLadder.Core.GameAssets
{
    public record Ladder(int BottomPosition, int TopPosition) : IPortal
    {
        public void Teleport(Player player) => player.Move(this.TopPosition);

        public bool IsPresentAt(int location) => this.BottomPosition == location;

        public (int start, int end) GetLocation() => (BottomPosition, TopPosition);
    }
}