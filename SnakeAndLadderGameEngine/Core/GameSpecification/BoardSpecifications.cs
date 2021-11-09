using System.Collections.Generic;
using SnakeLadder.Core.GameAssets;

namespace SnakeLadder.Core.GameSpecification
{
    public class BoardSpecifications
    {
        public int Width { get; }

        public int Height { get; }

        public PortalSpecifications PortalSpecifications { get; }

        public BoardSpecifications()
        {
            Width = 10;
            Height = 10;
            PortalSpecifications = new PortalSpecifications();
        }
    }
}