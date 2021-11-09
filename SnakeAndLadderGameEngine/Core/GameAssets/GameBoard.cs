using System.Collections.Generic;
using System.Linq;
using SnakeLadder.Core.GameAssets.Interfaces;

namespace SnakeLadder.Core.GameAssets
{
    public record GameBoard(int Width, int Height)
    {
        public int Destination = Width * Height;

        public readonly HashSet<IPortal> Portals = GetPortals();

        /// <summary>
        /// Playermovables present at player location
        /// Playermovables = Either snake or ladder because they moves player from Source to destination
        /// </summary>
        /// <param name="location"></param>
        /// <returns>Playermovables</returns>
        public IPortal IsPortalPresentAt(int location)
        {
            return this.Portals.FirstOrDefault(portal => portal.IsPresentAt(location));
        }

        private static HashSet<IPortal> GetPortals()
        {
            return new HashSet<IPortal>()
            {
                new Ladder(2,23,System.ConsoleColor.DarkYellow),
                new Ladder(8,24,System.ConsoleColor.Red),
                new Ladder(9,81,System.ConsoleColor.Green),
                new Ladder(29,65,System.ConsoleColor.Yellow),
                new Ladder(69,96,System.ConsoleColor.DarkMagenta),
                new Snake(14,7,System.ConsoleColor.Blue)
            };
        }
    }
}
