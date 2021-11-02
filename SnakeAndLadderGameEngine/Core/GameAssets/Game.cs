using SnakeLadder.Core.GamePlayer;

namespace SnakeLadder.Core.GameAssets
{
    public class Game
    {
        public Die Die { get; set; }

        public Player Player { get; set; }

        public GameBoard GameBoard { get; }

        public Game(Player player, Die die)
        {
            this.Player = player;
            this.Die = die;
            GameBoard = new GameBoard(10, 10);
        }

        public void Run()
        {
            var diceValue = this.Player.Play(this.Die);

            this.Player.Position = this.Player.Position + diceValue <= this.GameBoard.Destination ?
                                   this.Player.Position += diceValue :
                                   this.Player.Position;
        }
    }

}
