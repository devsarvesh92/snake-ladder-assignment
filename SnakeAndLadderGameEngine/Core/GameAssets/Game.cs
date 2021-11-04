using System.Linq;
using SnakeLadder.Core.GamePlayer;
using SnakeLadder.Core.GameState;

namespace SnakeLadder.Core.GameAssets
{
    public class Game
    {
        public CurrentGameState GameState { get; private set; }

        public Die Die { get; }

        public GameBoard GameBoard { get; }

        public Player Player { get; private set; }

        public Game(Player player, Die die)
        {
            this.Player = player;
            this.Die = die;
            GameBoard = new GameBoard(10, 10);
            GameState = new CurrentGameState();
        }

        public CurrentGameState Run()
        {
            if (this.GameState.NumberofTurnsLeft > 0)
            {
                var dieValue = this.Player.Play(this.Die);
                MovePlayer(dieValue);

                //Moves a player as per movble present at the location
                this.GameBoard.GetPlayerMovables(Player.Position)?.MovePlayer(this.Player);

                this.GameState.NumberofTurnsLeft--;
                this.GameState.PlayerPosition = this.Player.Position;
                this.GameState.DieValue = dieValue;
            }

            return this.GameState;
        }

        public bool IsGameOver() => this.GameState.PlayerPosition == this.GameBoard.Destination || this.GameState.NumberofTurnsLeft == 0;

        private void MovePlayer(int dieValue)
        {
            var position = this.Player.Position + dieValue <= this.GameBoard.Destination ?
                                   this.Player.Position + dieValue :
                                   this.Player.Position;
            this.Player.Move(position);
        }
    }
}
