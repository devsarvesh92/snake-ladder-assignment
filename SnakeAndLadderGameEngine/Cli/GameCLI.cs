using System;
using SnakeLadder.Core.GameAssets;
using SnakeLadder.Core.GamePlayer;
using SnakeLadder.UI;

namespace SnakeAndLadderGameEngine
{
    public class GameClI
    {
        public void Run()
        {
            Console.WriteLine("Welcome to SnakeAndLadder board game");
            Console.WriteLine();

            Console.WriteLine("Enter player name");

            //Build Player
            var playerName = Console.ReadLine();
            var player = new Player(playerName);

            Console.WriteLine($"Welome to SnakeAndLadder {player.Name}");
            Console.WriteLine();

            var game = new Game(player, new Die());

            var gameView = new GameView();
            gameView.RenderGameBoard(game.GameBoard);

            while (!game.IsGameOver())
            {
                Console.WriteLine("Press any key to role a dice");
                Console.ReadLine();

                game.Run();
                System.Console.WriteLine($"Die value {game.GameState.DieValue}");
                System.Console.WriteLine($"{game.Player.Name} is now at {game.GameState.PlayerPosition} and number of turns left {game.GameState.NumberofTurnsLeft}");
            }


            Console.ReadLine();
            System.Console.WriteLine("Game over");
            Console.ReadLine();
            Console.WriteLine("Work in progress stay tuned");
            Console.WriteLine("Press any key to exit");

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}