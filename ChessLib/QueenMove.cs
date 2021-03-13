using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessLib
{
    public class QueenMove
    {
        public IEnumerable<Position> ValidMovesFor(Position pos)
        {
            var bishopMove = new BishopMove();
            var rookMove = new RookMove();

            return bishopMove.ValidMovesFor(pos).Concat(rookMove.ValidMovesFor(pos));
        }
    }
}
