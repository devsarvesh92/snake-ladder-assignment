using System;

namespace SnakeLadder.Core.GameAssets
{
    public class NormalDie : Die
    {
        private readonly Random random = new Random();

        public override int Roll() => random.Next(1, 7);
    }
}