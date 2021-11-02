using System;
using System.Collections.Generic;
using SnakeLadder.Core.GameAssets;
using SnakeLadder.Core.GamePlayer;
using Xunit;

namespace SnakeLadderGameEngine.Tests
{
    public class PlayerTests
    {
        [Theory]
        [MemberData(nameof(PlayerPlayTestDataForValueShouldbeBetween1And6))]

        public void Play_ValueShouldbeBetween1And6(Die die, string name, int initialPosition)
        {
            //Act

            Player player = new Player(name, initialPosition);
            var valueOnDice = player.Play(die);

            //Assert

            Assert.InRange(valueOnDice, 1, 6);
        }

        [Theory]
        [MemberData(nameof(PlayerPlayTestDataForArgumentNullException))]

        public void Play_NullDiceArgumentShouldThrowArgumentNullException(Die die, string name, int initialPosition, string message)
        {
            //Act

            Player player = new Player(name, initialPosition);

            //Assert

            var exception = Assert.Throws<ArgumentNullException>("die", () => player.Play(die));
            Assert.Equal(exception.Message, message);
        }

        #region PlayerTest TestData
        public static IEnumerable<object[]> PlayerPlayTestDataForValueShouldbeBetween1And6 =>
        new List<object[]>
        {
            new object[] { new Die(),"Sarvesh",1 },
        };

        public static IEnumerable<object[]> PlayerPlayTestDataForArgumentNullException =>
        new List<object[]>
        {
            new object[] { null,"Sarvesh",1 ,"Please select a dice in order for continue playing (Parameter 'die')"},
        };
        #endregion
    }


}
