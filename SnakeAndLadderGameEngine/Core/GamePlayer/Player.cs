using SnakeLadder.Core.GameAssets;
using SnakeLadder.Core.GameExceptions;

namespace SnakeLadder.Core.GamePlayer
{
    public class Player
    {
        public string Name { get; private set; }

        public int Position { get; private set; }

        public Player(string name)
        {
            this.Name = string.IsNullOrWhiteSpace(name) ? throw new InvalidPlayerNameException("Player name is empty. Please enter valid name") : name;
            this.Position = 1;
        }

        public int Play(Die die) => die.Roll();

        public void Move(int cellNumber) => this.Position = cellNumber;
    }
}