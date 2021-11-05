using System;
using SnakeLadder.Core.GameAssets;
using SnakeLadder.Core.GameAssets.DieTypes;
using Xunit;

namespace SnakeLadderGameEngine.Tests
{
    public class NormalDieTests
    {
        [Fact]
        public void Roll_ValueShouldbeInBetween1And6()
        {
            //Act
            var dice = new NormalDie();
            var actual = dice.Roll();

            //Assert
            Assert.InRange(actual, 1, 6);
        }
    }
}
