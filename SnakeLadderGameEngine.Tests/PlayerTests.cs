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

        public void Play_ValueShouldbeBetween1And6(Die die, string name)
        {
            //Act

            Player player = new Player(name);
            var valueOnDice = player.Play(die);

            //Assert

            Assert.InRange(valueOnDice, 1, 6);
        }
        
        #region PlayerTest TestData
        public static IEnumerable<object[]> PlayerPlayTestDataForValueShouldbeBetween1And6 =>
        new List<object[]>
        {
            new object[] { new Die(),"Sarvesh" },
        };
        #endregion
    }
}
