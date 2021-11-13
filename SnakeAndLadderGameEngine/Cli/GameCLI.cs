using System;
using SnakeLadder.Core.GameAssets;
using SnakeLadder.Core.GameExceptions;
using SnakeLadder.Core.GamePlayer;
using SnakeLadder.Core.GameSpecification;

namespace SnakeAndLadderGameEngine
{
    public class GameClI
    {
        private BoardSpecifications BoardSpecifications { get; }

        public GameClI(BoardSpecifications boardSpecifications)
        {
            this.BoardSpecifications = boardSpecifications;
        }

        public void Run()
        {
            try
            {
                Console.WriteLine("Welcome to SnakeAndLadder board game");
                Console.WriteLine();

                Console.WriteLine("Enter player name");

                //Build Player
                var playerName = Console.ReadLine();
                var player = new Player(playerName);

                Console.WriteLine($"Welcome to SnakeAndLadder {player.Name}");
                Console.WriteLine();

                var game = new Game(player, this.BoardSpecifications);

                RenderGameBoard(game.GameBoard);

                while (!game.IsGameOver())
                {
                    Console.WriteLine("Press any key to role a die");
                    Console.ReadLine();

                    game.Run();
                    System.Console.WriteLine($"Die value {game.CurrentGameState.DieValue}");
                    System.Console.WriteLine(
                        $"{game.Player.Name} is now at {game.CurrentGameState.PlayerPosition} and number of turns left {game.CurrentGameState.NumberOfTurnsLeft}");
                    Console.ReadLine();
                }

                Console.ForegroundColor = game.GetResult().Equals(SnakeLadder.Core.GameResult.Result.Won)
                    ? ConsoleColor.Green
                    : ConsoleColor.Yellow;
                Console.WriteLine($"{game.Player.Name} has {game.GetResult().ToString()} the game");
                Console.ReadLine();

                System.Console.WriteLine("Game over");
                Console.ReadLine();

                Console.WriteLine();
                Console.ReadLine();
            }
            catch (InvalidPlayerNameException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(ex.Message);
                Console.WriteLine("Press any key to exit");
                Console.ReadLine();
            }
            catch (DuplicatePortalException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(ex.Message);
                Console.WriteLine("Press any key to exit");
                Console.ReadLine();
            }

            ResetConsoleColor();
        }

        private void RenderGameBoard(GameBoard gameBoard)
        {
            Console.WriteLine("Loading gameBoard");
            Console.WriteLine("");

            var portals = gameBoard.Portals;
            //Render Game Board
            var seedRowStartIndex = 1;
            for (var i = 0; i < gameBoard.BoardSpecifications.Height; i++)
            {
                for (var j = seedRowStartIndex; j < seedRowStartIndex + gameBoard.BoardSpecifications.Width; j++)
                {
                    var portal = gameBoard.IsPortalPresentAt(j);
                    if (portal != null)
                    {
                        if (portal is Snake snake)
                        {
                            RenderSnake(snake, j);
                        }
                        else if (portal is Ladder ladder)
                        {
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
                seedRowStartIndex += gameBoard.BoardSpecifications.Width;
            }

            Console.WriteLine("");
            Console.WriteLine("Loading complete");
            Console.WriteLine("");
        }

        private void RenderSnake(Snake snake, int location)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.Write($"|{location} S {(snake.HeadStart, snake.TailEnd)}|");
        }

        private void RenderLadder(Ladder ladder, int location)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.Write($"|{location} L {(ladder.BottomPosition, ladder.TopPosition)}|");
        }

        private void ResetConsoleColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}