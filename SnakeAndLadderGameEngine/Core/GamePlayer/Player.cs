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

        public int Play(Dice dice)
        {
            if (dice != null)
            {
                return dice.Roll();
            }
            else
            {
                throw new ArgumentNullException("dice", "Please select a dice in order for continue playing");
            }
        }
    }

}