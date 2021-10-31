using SnakeLadder.Core.GamePlayer;

namespace SnakeLadder.Core.GameAssets
{
    public class Game
    {

        public Player Player { get; set; }

        public GameBoard GameBoard { get; set; }

        public Game(Player player)
        {
            this.Player = player;
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