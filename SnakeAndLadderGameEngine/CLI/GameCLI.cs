using System;
using SnakeLadder.Core.GameAssets;
using SnakeLadder.UI;

namespace SnakeAndLadderGameEngine
{
    public class GameCLI
    {
        public void Run()
        {
            Console.WriteLine("Welcome to Snake and Ladder board game.");

            Game game = new Game();
            
            GameView gameView = new GameView();
            gameView.Render(game.GameBoard);

            Console.WriteLine("Work in Progress Stay Tuned..");
            Console.WriteLine("Press Any key to Exit..");

            Console.ReadLine();
        }
    }

}