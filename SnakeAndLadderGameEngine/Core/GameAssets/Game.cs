using System;
using System.Collections.Generic;
using System.Linq;
using SnakeLadder.Core.GamePlayer;
using SnakeLadder.Core.GameStates;
using SnakeLadder.Core.GameResult;
using SnakeLadder.Core.GameSpecification;

namespace SnakeLadder.Core.GameAssets
{
    public class Game
    {
        public GameState CurrentGameState { get; private set; }

        private Die Die { get; }

        public GameBoard GameBoard { get; }

        public Player Player { get; private set; }

        public Game(Player player, BoardSpecifications boardSpecifications)
        {
            var random = new Random();
            this.Player = player;
            this.Die = new List<Die>() { new FairDie(), new CrookedDie() }[random.Next(0, 2)];
            GameBoard = new GameBoard(boardSpecifications);
            CurrentGameState = new GameState();
        }

        public GameState Run()
        {
            Action actionToPlay = () =>
            {
                var dieValue = this.Player.Play(this.Die);
                AdvancePlayer(dieValue);
                this.GameBoard.IsPortalPresentAt(Player.Position)?.Teleport(this.Player);
                this.CurrentGameState.DieValue = dieValue;
            };

            this.Play(actionToPlay);
            return this.CurrentGameState;
        }

        public bool IsGameOver() => this.CurrentGameState.PlayerPosition.Equals(this.GameBoard.Destination) || this.CurrentGameState.NumberOfTurnsLeft.Equals(0);

        public Result GetResult()
        {
            if (this.IsGameOver())
            {
                return this.CurrentGameState.PlayerPosition.Equals(this.GameBoard.Destination) ? Result.Won : Result.Lost;
            }
            else
            {
                return Result.InProgress;
            }
        }

        private void Play(Action actionToPlay)
        {
            if (this.CurrentGameState.IsTurnAvailable())
            {
                actionToPlay();
                this.CurrentGameState.NumberOfTurnsLeft--;
                this.CurrentGameState.PlayerPosition = this.Player.Position;
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
