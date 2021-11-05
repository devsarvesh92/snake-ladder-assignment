using System;
using System.Collections.Generic;
using System.Linq;
using SnakeLadder.Core.GameAssets;
using SnakeLadder.Core.GamePlayer;

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

            RenderGameBoard(game.GameBoard);

            while (!game.IsGameOver())
            {
                Console.WriteLine("Press any key to role a dice");
                Console.ReadLine();

                game.Run();
                System.Console.WriteLine($"Die value {game.CurrentGameState.DieValue}");
                System.Console.WriteLine($"{game.Player.Name} is now at {game.CurrentGameState.PlayerPosition} and number of turns left {game.CurrentGameState.NumberofTurnsLeft}");
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

        private void RenderGameBoard(GameBoard gameBoard)
        {
            Console.WriteLine("Loading gameBoard");
            Console.WriteLine("");

            var snakes = gameBoard.Snakes;
            var ladders = gameBoard.Ladders;
            //Render Game Board
            int seedRowStartIndex = 1;
            for (int i = 0; i < gameBoard.Height; i++)
            {
                for (int j = seedRowStartIndex; j < seedRowStartIndex + gameBoard.Width; j++)
                {

                    var snakePresentAtlocation = snakes.FirstOrDefault(snake => snake.headStart == j || snake.tailEnd == j);
                    var ladderPresentAtlocation = ladders.FirstOrDefault(ladder => ladder.topPosition == j || ladder.bottomPosition == j);

                    if (snakePresentAtlocation != null)
                    {
                        Console.ForegroundColor = snakePresentAtlocation.snakeColor;
                        System.Console.Write($"|{j} S {(snakePresentAtlocation.headStart, snakePresentAtlocation.tailEnd)}|");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (ladderPresentAtlocation != null)
                    {
                        Console.ForegroundColor = ladderPresentAtlocation.ladderColor;
                        System.Console.Write($"|{j} L {(ladderPresentAtlocation.topPosition, ladderPresentAtlocation.bottomPosition)}|");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        System.Console.Write($"|{j}|");
                    }
                }
                System.Console.WriteLine();
                seedRowStartIndex += gameBoard.Width;
            }

            Console.WriteLine("");
            Console.WriteLine("Loading complete");
            Console.WriteLine("");
        }
    }
}