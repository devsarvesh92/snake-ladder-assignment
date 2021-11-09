namespace SnakeLadder.Core.GameStates
{
    public class GameState
    {
        public GameState()
        {
            NumberOfTurnsLeft = 10;
        }

        public int NumberOfTurnsLeft { get; set; }

        public int PlayerPosition { get; set; }

        public int DieValue { get; set; }
    }
}