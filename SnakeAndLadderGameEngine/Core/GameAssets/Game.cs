using System;
using System.Collections.Generic;
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

        private readonly Random random;

        public Game(Player player)
        {
            random = new Random();
            this.Player = player;
            this.Die = GetRandomDie();
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

        /// <summary>
        /// Selects either normal or crooked die
        /// Normal die gives values between 1 and 6
        /// Crooked die gives even values between 2 and 6
        /// </summary>
        /// <returns></returns>
        private Die GetRandomDie()
        {
            //Choose random dice
            var listOfAvailableDices = new List<Die>() { new NormalDie(), new CrookedDie() };
            return listOfAvailableDices.ElementAt(this.random.Next(0, 2));
        }
    }
}
