using System;
using SnakeLadder.Core.GameAssets;
using Xunit;

namespace SnakeLadderGameEngine.Tests
{
    public class FairDieTests
    {
        [Fact]
        public void Roll_ValueShouldbeInBetween1And6()
        {
            //Act
            var dice = new FairDie();
            var actual = dice.Roll();

            //Assert
            Assert.InRange(actual, 1, 6);
        }
    }
}
