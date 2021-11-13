using System;

namespace SnakeLadder.Core.GameAssets
{
    public class CrookedDie : Die
    {
        private readonly Random _random = new Random();

        public override int Roll() => _random.Next(2, 7) / 2 * 2;
    }
}