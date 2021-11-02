using SnakeLadder.Core.GamePlayer;

namespace SnakeLadder.Core.GameAssets
{
    public class Game
    {
        public Die Die { get; set; }

        public Player Player { get; set; }

        public GameBoard GameBoard { get; set; }

        public Game(Player player, Die die)
        {
            this.Player = player;
            this.Die = die;
            GameBoard = BuildGameBoard();
        }

        public void Run()
        {
            var diceValue = this.Player.Play(this.Die);

            this.Player.Position = this.Player.Position + diceValue <= this.GameBoard.Destination ?
                                   this.Player.Position += diceValue :
                                   this.Player.Position;
        }

        private GameBoard BuildGameBoard() => new GameBoard()
        {
            Destination = 100,
            Width = 10,
            Height = 10,
        };
    }

}