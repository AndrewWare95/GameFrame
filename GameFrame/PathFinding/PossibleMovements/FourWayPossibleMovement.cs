﻿using Microsoft.Xna.Framework;

namespace GameFrame.PathFinding.PossibleMovements
{
    public class FourWayPossibleMovement : IPossibleMovements
    {
        public Point[] GetAdjacentLocations(Point fromLocation)
        {
            return new[]
            {
                new Point(fromLocation.X-1, fromLocation.Y  ),
                new Point(fromLocation.X,   fromLocation.Y+1),
                new Point(fromLocation.X+1, fromLocation.Y  ),
                new Point(fromLocation.X,   fromLocation.Y-1)
            };
        }
    }
}