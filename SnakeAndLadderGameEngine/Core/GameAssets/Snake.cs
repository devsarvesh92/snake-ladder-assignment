using System;
using SnakeLadder.Core.GameAssets.Interfaces;
using SnakeLadder.Core.GamePlayer;

namespace SnakeLadder.Core.GameAssets
{
    public record Snake(int HeadStart, int TailEnd) : IPortal
    {
        public void Teleport(Player player) => player.Move(this.TailEnd);

        public bool IsPresentAt(int location) => this.HeadStart == location;

        public (int start, int end) GetLocation() => (HeadStart, TailEnd);
    }
}