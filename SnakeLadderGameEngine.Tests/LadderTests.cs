using System;
using System.Collections.Generic;
using System.Linq;
using SnakeLadder.Core.GameAssets;
using SnakeLadder.Core.GamePlayer;
using Xunit;

namespace SnakeLadderGameEngine.Tests
{
    public class LadderTests
    {

        [Theory]
        [MemberData(nameof(TestDataForPlayerShouldMoveFrom8to24OnLadderClimb))]

        public void MovePlayer_PlayerShouldMoveFrom8to24(Game game)
        {
            //Arrange
            var actual = 24;

            //Act
            game.Player.Move(8);
            game.GameBoard.GetPlayerMovables(8)?.Teleport(game.Player);
            var expected = game.Player.Position;

            //Assert
            Assert.Equal(expected, actual);
        }

        #region Ladder Test TestData
        public static IEnumerable<object[]> TestDataForPlayerShouldMoveFrom8to24OnLadderClimb =>
        new List<object[]>
        {
            new object[] { new Game(new Player("Sarvesh")) },
        };
        #endregion
    }
}