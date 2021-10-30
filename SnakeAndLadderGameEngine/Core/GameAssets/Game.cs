
namespace SnakeLadder.Core.GameAssets
{
    public class Game
    {
        public Game()
        {
            GameBoard = BuildGameBoard();
        }

        public GameBoard GameBoard { get; set; }

        private GameBoard BuildGameBoard () => new GameBoard()
        {
            Destination = 100,
            Width = 10,
            Height = 10,
        };

    }

}