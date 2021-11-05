namespace SnakeLadder.Core.GameStates
{
    public class GameState
    {
        public GameState()
        {
            NumberofTurnsLeft = 10;
        }

        public int NumberofTurnsLeft { get; set; }

        public int PlayerPosition { get; set; }

        public int DieValue { get; set; }
    }
}