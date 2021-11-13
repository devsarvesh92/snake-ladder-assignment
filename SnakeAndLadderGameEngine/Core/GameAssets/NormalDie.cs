using System;

namespace SnakeLadder.Core.GameAssets
{
    public class FairDie : Die
    {
        private readonly Random _random = new Random();

        public override int Roll() => _random.Next(1, 7);
    }
}