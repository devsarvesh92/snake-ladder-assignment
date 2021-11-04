using SnakeLadder.Core.GamePlayer;

public interface IMovable
{
    /// <summary>
    /// Represents player movement as per movable object
    /// </summary>
    /// <param name="player"></param>
    public void MovePlayer(Player player);
}