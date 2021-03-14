using System.Collections.Generic;
using System.Linq;

namespace ChessLib
{
    public class QueenMove
    {
        public IEnumerable<Position> ValidMovesFor(Position pos)
        {
            // Queen moves like Rook and Bishop combined
            var bishopMove = new BishopMove();
            var rookMove = new RookMove();

            return bishopMove.ValidMovesFor(pos).Concat(rookMove.ValidMovesFor(pos));
        }
    }
}
