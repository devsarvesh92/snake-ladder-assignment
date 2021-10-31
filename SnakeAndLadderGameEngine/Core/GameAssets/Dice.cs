using System;

namespace SnakeLadder.Core.GameAssets
{
    public class Dice
    {
        private readonly Random random = new Random();
        
        public int Roll() => random.Next(1, 7);
    }

}