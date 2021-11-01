using System;
using SnakeLadder.Core.GameAssets;
using Xunit;

namespace SnakeLadderGameEngine.Tests
{
    public class DiceTests
    {
        [Fact]
        public void Roll_ValueShouldbeInBetween1And6()
        {
            //Act
            Dice dice = new Dice();
            var actual = dice.Roll();

            //Assert
            Assert.InRange(actual,1,6);
        }
    }
}
