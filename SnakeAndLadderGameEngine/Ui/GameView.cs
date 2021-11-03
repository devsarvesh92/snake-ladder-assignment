using System;
using System.Collections.Generic;
using System.Linq;
using SnakeLadder.Core.GameAssets;

namespace SnakeLadder.UI
{
    public class GameView
    {
        public void RenderGameBoard(GameBoard gameBoard)
        {
            Console.WriteLine("Loading gameBoard");
            Console.WriteLine("");

            var snakes = gameBoard.Snakes;
            //Render Game Board
            int seedRowStartIndex = 1;
            for (int i = 0; i < gameBoard.Height; i++)
            {
                for (int j = seedRowStartIndex; j < seedRowStartIndex + gameBoard.Width; j++)
                {

                    var snakePresentAtlocation = snakes.FirstOrDefault(snake => snake.headStart == j || snake.tailEnd == j);
                    if (snakePresentAtlocation != null)
                    {
                        Console.ForegroundColor = snakePresentAtlocation.snakeColor;
                        System.Console.Write($"|{j} S {(snakePresentAtlocation.headStart,snakePresentAtlocation.tailEnd)}|");
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