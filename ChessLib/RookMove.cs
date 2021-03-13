using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessLib
{
    public class RookMove
    {
        public static readonly (int X, int Y)[] Directions = new[] { (1, 1), (1, -1), (-1, 1), (-1, -1) };
        public IEnumerable<Position> ValidMovesFor(Position pos)
        {
            foreach (var d in Directions)
            {
                for (var i = 1; i <= 7; i++)
                {
                    var newX = pos.X + i * d.X;
                    var newY = pos.Y + i * d.Y;
                    if (newX > 8 || newX < 1 || newY > 8 || newY < 1)
                        break; // If I go outside of the board there is no need to continue looking further.
                    yield return new Position(newX, newY);
                }
            }
        }
    }
}
