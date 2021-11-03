using System;
using SnakeLadder.Core.GamePlayer;

namespace SnakeLadder.Core.GameAssets
{
    public record Ladder(int start, int end, ConsoleColor ladderColor);
}