using System;
using System.Collections.Generic;
using System.Linq;
using SnakeLadder.Core.GameAssets;
using SnakeLadder.Core.GamePlayer;
using Xunit;

namespace SnakeLadderGameEngine.Tests
{
    public class GameTests
    {

        [Theory]
        [MemberData(nameof(TestDataGameTests))]

        public void Run_PlayerShouldMoveFromInitialPoisitionAndNumberofTurnsShouldGetReducedto9(Game game)
        {

            //Act
            var initialPosition = game.Player.Position;
            game.Run();

            //Assert
            Assert.NotEqual(initialPosition, game.Player.Position);
            Assert.Equal(game.Player.Position, game.CurrentGameState.PlayerPosition);
            Assert.Equal(9, game.CurrentGameState.NumberofTurnsLeft);
        }

        [Theory]
        [MemberData(nameof(TestDataGameTests))]
        public void IsGameOver_ShouldReturnTrueWhenPlayerHasReadchedDestination(Game game)
        {
            //Arrange
            game.Player.Move(100);
            game.CurrentGameState.PlayerPosition = game.Player.Position;

            //Act
            var actual = game.IsGameOver();

            //Assert
            Assert.True(actual);
        }

        [Theory]
        [MemberData(nameof(TestDataGameTests))]
        public void IsGameOver_ShouldReturnTrueWhenNoTurnsLeftToPlay(Game game)
        {
            //Arrange
            game.CurrentGameState.NumberofTurnsLeft = 0;

            //Act
            var actual = game.IsGameOver();

            //Assert
            Assert.True(actual);
        }

        [Theory]
        [MemberData(nameof(TestDataGameTests))]
        public void GetResult_ShouldReturnWinWhenPlayerReachedDestination(Game game)
        {
            //Arrange
            game.Player.Move(100);
            game.CurrentGameState.PlayerPosition = game.Player.Position;

            //Act
            var actual = game.GetResult();

            //Assert
            Assert.Equal(SnakeLadder.Core.GameResult.Result.Win, actual);
        }



        [Theory]
        [MemberData(nameof(TestDataGameTests))]
        public void IsGameOver_ShouldReturnLostWhenNoTurnsLeftToPlayAndPlayerHasNotReachedDestination(Game game)
        {
            //Arrange
            game.CurrentGameState.NumberofTurnsLeft = 0;

            //Act
            var actual = game.GetResult();

            //Assert
            Assert.Equal(SnakeLadder.Core.GameResult.Result.Lose, actual);
        }

        [Theory]
        [MemberData(nameof(TestDataGameTests))]
        public void IsGameOver_ShouldReturnInProgressWhenTurnsLeftToPlayAndPlayerHasNotReachedDestination(Game game)
        {
            //Arrange
            game.CurrentGameState.NumberofTurnsLeft = 5;

            //Act
            var actual = game.GetResult();

            //Assert
            Assert.Equal(SnakeLadder.Core.GameResult.Result.InProgress, actual);
        }

        #region Game Test TestData
        public static IEnumerable<object[]> TestDataGameTests =>
        new List<object[]>
        {
            new object[] { new Game(new Player("Sarvesh")) },
        };
        #endregion
    }
}