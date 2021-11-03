using System;
using SnakeLadder.Core.GameAssets;

namespace SnakeLadder.Core.GamePlayer
{
    public class Player
    {
        public string Name { get; private set; }

        public int Position { get; private set; }

        public Player(string name)
        {
            this.Name = name;
            this.Position = 1;
        }

        public int Play(Die die) => die.Roll();

        public void Move(int destination) => this.Position = destination;
    }
}