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
            var player = new Player(playerName, 1);

            Console.WriteLine($"Welome to SnakeAndLadder {player.Name}");
            Console.WriteLine();

            Console.WriteLine("Press Any key to select dice");
            Console.ReadLine();
            Console.WriteLine("Dice is Selected");
            Console.WriteLine();

            //Build Game
            Game game = new Game(player, new Dice());

            //Render View
            GameView gameView = new GameView();
            gameView.RenderGameBoard(game.GameBoard);

            //Start Game Play
            while (game.Player.Position < game.GameBoard.Destination)
            {
                Console.WriteLine("Press Any key to role a dice..");
                Console.ReadLine();

                game.Run();
            }

            Console.WriteLine("Work in Progress Stay Tuned..");
            Console.WriteLine("Press Any key to Exit..");

            Console.WriteLine();
            Console.ReadLine();
        }
    }

}