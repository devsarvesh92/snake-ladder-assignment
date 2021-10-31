using SnakeLadder.Core.GamePlayer;

namespace SnakeLadder.Core.GameAssets
{
    public class Game
    {
        public Dice Dice { get; set; }

        public Player Player { get; set; }

        public GameBoard GameBoard { get; set; }

        public Game(Player player, Dice dice)
        {
            this.Player = player;
            this.Dice = dice;
            GameBoard = BuildGameBoard();
        }

        private GameBoard BuildGameBoard() => new GameBoard()
        {
            Destination = 100,
            Width = 10,
            Height = 10,
        };
    }

}