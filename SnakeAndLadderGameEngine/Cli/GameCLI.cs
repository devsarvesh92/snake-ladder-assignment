using System;
using System.Collections.Generic;
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

            var game = new Game(player);

            var gameView = new GameView();
            gameView.RenderGameBoard(game.GameBoard);

            while (!game.IsGameOver())
            {
                Console.WriteLine("Press any key to role a dice");
                Console.ReadLine();

                game.Run();
                System.Console.WriteLine($"Die value {game.GameState.DieValue}");
                System.Console.WriteLine($"{game.Player.Name} is now at {game.GameState.PlayerPosition} and number of turns left {game.GameState.NumberofTurnsLeft}");
                Console.ReadLine();
            }

            Console.ForegroundColor = game.GetResult() == SnakeLadder.Core.GameResult.Result.Win ? ConsoleColor.Green : ConsoleColor.Yellow;
            Console.WriteLine($"{game.Player.Name} has {game.GetResult().ToString()} the game");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            System.Console.WriteLine("Game over");
            Console.ReadLine();

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}