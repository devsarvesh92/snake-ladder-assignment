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
                Console.WriteLine("Press any key to role a die");
                Console.ReadLine();

                game.Run();
                System.Console.WriteLine($"Die value {game.CurrentGameState.DieValue}");
                System.Console.WriteLine($"{game.Player.Name} is now at {game.CurrentGameState.PlayerPosition} and number of turns left {game.CurrentGameState.NumberOfTurnsLeft}");
                Console.ReadLine();
            }

            Console.ForegroundColor = game.GetResult().Equals(SnakeLadder.Core.GameResult.Result.Win) ? ConsoleColor.Green : ConsoleColor.Yellow;
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

            var portals = gameBoard.Portals;
            //Render Game Board
            var seedRowStartIndex = 1;
            for (var i = 0; i < gameBoard.Height; i++)
            {
                for (var j = seedRowStartIndex; j < seedRowStartIndex + gameBoard.Width; j++)
                {
                    var portal = gameBoard.IsPortalPresentAt(j);
                    if (portal != null)
                    {
                        if (portal is Snake)
                        {
                            var snake = portal as Snake;
                            RenderSnake(snake, j);
                        }
                        else if (portal is Ladder)
                        {
                            var ladder = portal as Ladder;
                            RenderLadder(ladder, j);
                        }
                    }
                    else
                    {
                        System.Console.Write($"|{j}|");
                    }
                    ResetConsoleColor();
                }
                System.Console.WriteLine();
                seedRowStartIndex += gameBoard.Width;
            }

            Console.WriteLine("");
            Console.WriteLine("Loading complete");
            Console.WriteLine("");
        }

        private void RenderSnake(Snake snake, int location)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.Write($"|{location} S {(snake.headStart, snake.tailEnd)}|");
        }

        private void RenderLadder(Ladder ladder, int location)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.Write($"|{location} L {(ladder.bottomPosition, ladder.topPosition)}|");
        }

        private void ResetConsoleColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}