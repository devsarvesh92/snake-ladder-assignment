namespace SnakeLadder.Core.GameAssets
{
    public record GameBoard(int Width, int Height)
    {
        public int Destination = Width * Height;
    }
}
