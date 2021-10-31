using System;
using SnakeLadder.Core.GameAssets;
using SnakeLadder.Core.GamePlayer;
using SnakeLadder.UI;

namespace SnakeAndLadderGameEngine
{
    public class GameCLI
    {
        public void Run()
        {
            Console.WriteLine("Welcome to Snake and Ladder board game.");
            Console.WriteLine("Loading...");
            Console.WriteLine();

            Console.WriteLine("Enter Player Name");

            //Build Player
            var playerName = Console.ReadLine();
            var player = new Player(playerName,1);

            Console.WriteLine($"Welome to SnakeAndLadder {player.Name}");
            Console.WriteLine();

            //Build Game
            Game game = new Game(player);

            //Render View
            GameView gameView = new GameView();
            gameView.RenderGameBoard(game.GameBoard);


            Console.WriteLine("Work in Progress Stay Tuned..");
            Console.WriteLine("Press Any key to Exit..");
            Console.WriteLine();
            Console.ReadLine();
        }
    }

}