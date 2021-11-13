using System;
using SnakeAndLadderGameEngine;
using SnakeLadder.Core.GameSpecification;

namespace SnakeLadderAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var boardSpecifications = new BoardSpecifications();
            var gameCli = new GameClI(boardSpecifications);
            gameCli.Run();
        }
    }
}