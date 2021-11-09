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

        public void Play_ValueShouldbeBetween1And6(string name, Die die)
        {
            //Act

            Player player = new Player(name);
            var valueOnDie = player.Play(die);

            //Assert

            Assert.InRange(valueOnDie, 1, 6);
        }

        [Theory]
        [MemberData(nameof(PlayerPlayTestDataForAnyEvenValueBetween2And6))]

        public void Play_ValueShouldbeAnyEvenValueBetween2And6(string name, Die die)
        {
            //Act

            Player player = new Player(name);
            var valueOnDie = player.Play(die);

            //Assert

            Assert.Equal(0, valueOnDie % 2);
        }


        #region PlayerTest TestData
        public static IEnumerable<object[]> PlayerPlayTestDataForValueShouldbeBetween1And6 =>
        new List<object[]>
        {
            new object[] { "Sarvesh" , new FairDie()},
        };

        public static IEnumerable<object[]> PlayerPlayTestDataForAnyEvenValueBetween2And6 =>
        new List<object[]>
        {
            new object[] { "Sarvesh" , new CrookedDie()},
        };
        #endregion
    }
}
