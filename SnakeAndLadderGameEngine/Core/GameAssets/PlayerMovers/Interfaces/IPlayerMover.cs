using SnakeLadder.Core.GamePlayer;
namespace SnakeLadder.Core.GameAssets.PlayerMovers.Interfaces
{
    public interface IPlayerMover
    {
        /// <summary>
        /// Moves player as per movable object
        /// </summary>
        /// <param name="player"></param>
        public void MovePlayer(Player player);
    }
}