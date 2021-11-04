using System;
using System.Linq;

namespace SnakeLadder.Core.GameAssets
{
    public class CrookedDie : Die
    {
        private readonly Random random = new Random();

        public override int Roll() => Enumerable.Range(1, 7).Where(num => num % 2 == 0).ToArray()[random.Next(0, 3)];
    }
}