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
            Console.WriteLine("Welcome to SnakeAndLadder board game");
            Console.WriteLine();

            Console.WriteLine("Enter player name");

            //Build Player
            var playerName = Console.ReadLine();
            var player = new Player(playerName, 1);

            Console.WriteLine($"Welome to SnakeAndLadder {player.Name}");
            Console.WriteLine();

            Console.WriteLine("Press Any key to select dice");
            Console.ReadLine();

            Game game = new Game(player, new Dice());

            GameView gameView = new GameView();
            gameView.RenderGameBoard(game.GameBoard);

            while (game.Player.Position < game.GameBoard.Destination)
            {
                Console.WriteLine("Press any key to role a dice");
                Console.ReadLine();

                game.Run();
            }

            Console.WriteLine("Work in progress stay tuned");
            Console.WriteLine("Press any key to exit");

            Console.WriteLine();
            Console.ReadLine();
        }
    }

}