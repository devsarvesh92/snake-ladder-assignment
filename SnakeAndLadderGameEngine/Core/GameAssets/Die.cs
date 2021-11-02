using System;

namespace SnakeLadder.Core.GameAssets
{
    public class Die
    {
        private readonly Random random = new Random();
        
        public int Roll() => random.Next(1, 7);
    }

}