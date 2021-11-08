using System;

namespace SnakeLadder.Core.GameAssets
{
    public class FairDie : Die
    {
        private readonly Random random = new Random();

        public override int Roll() => random.Next(1, 7);
    }
}