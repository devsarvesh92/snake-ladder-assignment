using System;
using System.Collections.Generic;
using SnakeLadder.Core.GameAssets;

namespace SnakeLadder.UI
{
    public class GameView
    {
        public void Render(GameBoard gameBoard)
        {
            Console.WriteLine("Loading GameBoard...");
            
            //Render Game Board
            int seedRowStartIndex = 1;
            for (int i = 0; i < gameBoard.Height; i++)
            {
                for (int j = seedRowStartIndex; j < seedRowStartIndex + gameBoard.Width; j++)
                {
                    System.Console.Write($"|{j}|");
                }
                System.Console.WriteLine();
                seedRowStartIndex += gameBoard.Width;
            }

            Console.WriteLine("Loading Complete...");
            
        }

    }
}