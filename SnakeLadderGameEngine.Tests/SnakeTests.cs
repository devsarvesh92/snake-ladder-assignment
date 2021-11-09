using System;
using System.Collections.Generic;
using System.Linq;
using SnakeLadder.Core.GameAssets;
using SnakeLadder.Core.GamePlayer;
using Xunit;

namespace SnakeLadderGameEngine.Tests
{
    public class SnakeTests
    {

        [Theory]
        [MemberData(nameof(TestDataForPlayerShouldMoveFrom14to7OnSnakeBitr))]

        public void MovePlayer_PlayerShouldMoveFrom14to7(Game game)
        {
            //Arrange
            var actual = 7;

            //Act
            game.Player.Move(14);
            game.GameBoard.IsPortalPresentAt(14)?.Teleport(game.Player);
            var expected = game.Player.Position;

            //Assert
            Assert.Equal(expected, actual);
        }

        #region Snake Test TestData
        public static IEnumerable<object[]> TestDataForPlayerShouldMoveFrom14to7OnSnakeBitr =>
        new List<object[]>
        {
            new object[] { new Game(new Player("Sarvesh"), new SnakeLadder.Core.GameSpecification.BoardSpecifications()) },
        };
        #endregion
    }
}