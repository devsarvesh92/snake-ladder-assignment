using System;
using SnakeLadder.Core.GameAssets;

namespace SnakeLadder.Core.GamePlayer
{
    public class Player
    {
        public string Name { get; set; }
        
        public int Position { get; set; }
        
        public Player(string name, int position)
        {
            this.Name = name;
            this.Position = position;
        }

        public int Play(Dice dice) => dice.Roll();

    }

}