using SnakeLadder.Core.GamePlayer;
namespace SnakeLadder.Core.GameAssets.Interfaces
{
    public interface IPortal
    {
        /// <summary>
        /// Teleport a player from source to destination
        /// </summary>
        /// <param name="player"></param>
        public void Teleport(Player player);
    }
}