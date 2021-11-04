namespace SnakeLadder.Core.GameState
{
    public class CurrentGameState
    {
        public CurrentGameState()
        {
            NumberofTurnsLeft = 10;
        }

        public int NumberofTurnsLeft { get; set; }

        public int PlayerPosition { get; set; }

        public int DieValue { get; set; }
    }
}