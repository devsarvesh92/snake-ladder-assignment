using System;

namespace SnakeLadder.Core.GameAssets.DieTypes
{
    public class CrookedDie : Die
    {
        private readonly Random random = new Random();

        public override int Roll() => random.Next(2, 7) / 2 * 2;
    }
}