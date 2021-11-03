namespace SnakeLadder.Core.GameState
{
    public class CurrentGameState
    {
        public CurrentGameState()
        {
            NumberofTurnsLeft = 10;
        }

        internal int NumberofTurnsLeft { get; set; }

        internal int PlayerPosition { get; set; }

        internal int DieValue { get; set; }
    }
}