using System.Collections.Generic;
using SnakeLadder.Core.GameAssets;
using SnakeLadder.Core.GameAssets.Interfaces;

namespace SnakeLadder.Core.GameSpecification
{
    public class PortalSpecifications
    {
        public HashSet<IPortal> Portals { get; }

        public PortalSpecifications()
        {
            Portals = GetPortals();
        }

        private HashSet<IPortal> GetPortals()
        {
            return new HashSet<IPortal>()
            {
                new Ladder(2,23),
                new Ladder(8,24),
                new Ladder(9,81),
                new Ladder(29,65),
                new Ladder(69,96),
                new Snake(14,7)
            };
        }
    }
}