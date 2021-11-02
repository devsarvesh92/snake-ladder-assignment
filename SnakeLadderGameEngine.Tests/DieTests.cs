using System;
using SnakeLadder.Core.GameAssets;
using Xunit;

namespace SnakeLadderGameEngine.Tests
{
    public class DieTests
    {
        [Fact]
        public void Roll_ValueShouldbeInBetween1And6()
        {
            //Act
            var dice = new Die();
            var actual = dice.Roll();

            //Assert
            Assert.InRange(actual,1,6);
        }
    }
}
