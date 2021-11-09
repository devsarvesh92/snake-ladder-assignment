using SnakeLadder.Core.GamePlayer;
namespace SnakeLadder.Core.GameAssets.Interfaces
{
    public interface IPortal
    {
        public void Teleport(Player player);

        public bool IsPresentAt(int location);

        public (int start, int end) GetLocation();
    }
}