using System;
using System.Collections.Generic;
using System.Linq;
using SnakeLadder.Core.GamePlayer;
using SnakeLadder.Core.GameStates;
using SnakeLadder.Core.GameResult;

namespace SnakeLadder.Core.GameAssets
{
    public class Game
    {
        public GameState CurrentGameState { get; private set; }

        public Die Die { get; }

        public GameBoard GameBoard { get; }

        public Player Player { get; private set; }

        private readonly Random random;

        public Game(Player player)
        {
            random = new Random();
            this.Player = player;
            this.Die = new List<Die>() { new FairDie(), new CrookedDie() }[random.Next(0, 2)];
            GameBoard = new GameBoard(10, 10);
            CurrentGameState = new GameState();
        }

        public GameState Run()
        {
            if (this.CurrentGameState.NumberOfTurnsLeft > 0)
            {
                var dieValue = this.Player.Play(this.Die);
                AdvancePlayer(dieValue);

                //Moves a player as per movable present at the location
                this.GameBoard.GetPlayerMovables(Player.Position)?.Teleport(this.Player);

                this.CurrentGameState.NumberOfTurnsLeft--;
                this.CurrentGameState.PlayerPosition = this.Player.Position;
                this.CurrentGameState.DieValue = dieValue;
            }

            return this.CurrentGameState;
        }

        public bool IsGameOver() => this.CurrentGameState.PlayerPosition.Equals(this.GameBoard.Destination) || this.CurrentGameState.NumberOfTurnsLeft.Equals(0);

        public Result GetResult()
        {
            if (this.IsGameOver())
            {
                return this.CurrentGameState.PlayerPosition.Equals(this.GameBoard.Destination) ? Result.Win : Result.Lose;
            }
            else
            {
                return Result.InProgress;
            }
        }

        private void AdvancePlayer(int numberOfPositions)
        {
            var position = this.Player.Position + numberOfPositions <= this.GameBoard.Destination ?
                                   this.Player.Position + numberOfPositions :
                                   this.Player.Position;
            this.Player.Move(position);
        }
    }
}
