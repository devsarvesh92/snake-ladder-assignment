using System;
using System.Collections.Generic;
using System.Linq;
using SnakeLadder.Core.GameAssets.Interfaces;
using SnakeLadder.Core.GameExceptions;
using SnakeLadder.Core.GameSpecification;

namespace SnakeLadder.Core.GameAssets
{
    public record GameBoard(BoardSpecifications BoardSpecifications)
    {
        public int Destination = BoardSpecifications.Width * BoardSpecifications.Height;

        public readonly HashSet<IPortal> Portals = ValidatePortals(BoardSpecifications.PortalSpecifications.Portals) ? BoardSpecifications.PortalSpecifications.Portals : null;

        private static bool ValidatePortals(HashSet<IPortal> portals)
        {
            var duplicatePortals = portals.Select(portal =>
                                                    {
                                                        return portal.GetLocation();
                                                    }).
                                                    GroupBy(location => new { location.start, location.end }).
                                                    Where(portal => portal.Skip(1).Any());
            if (duplicatePortals != null && duplicatePortals.Any())
            {
                var duplicatePortalLocations = duplicatePortals.Select(loc => loc.Key.ToString());
                throw new DuplicatePortalException($"Duplicate portal exists at {string.Join(":", duplicatePortalLocations)}. Please contact support team");
            }
            return true;
        }

        public IPortal IsPortalPresentAt(int location) => this.Portals.FirstOrDefault(portal => portal.IsPresentAt(location));
    }
}
