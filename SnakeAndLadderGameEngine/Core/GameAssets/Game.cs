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

        public void Run()
        {
            var diceValue = this.Player.Play(this.Dice);

            System.Console.WriteLine($"Dice Result : {diceValue}");

            this.Player.Position = this.Player.Position + diceValue <= this.GameBoard.Destination ?
                                   this.Player.Position += diceValue :
                                   this.Player.Position;
            
            System.Console.WriteLine($"{this.Player.Name} is at {this.Player.Position}");
            System.Console.WriteLine();
        }

        private GameBoard BuildGameBoard() => new GameBoard()
        {
            Destination = 100,
            Width = 10,
            Height = 10,
        };
    }

}