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
            var die = new FairDie();
            var actual = die.Roll();

            //Assert
            Assert.InRange(actual, 1, 6);
        }
    }
}
