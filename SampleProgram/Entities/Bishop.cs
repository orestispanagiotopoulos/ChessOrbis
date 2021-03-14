using ChessLib;
using System.Collections.Generic;
using System.Linq;

namespace SampleProgram.Entities
{
    public class Bishop : Piece
    {
        public Bishop(Position pos) : base(pos)
        {
        }

        public override bool TryMove(List<Position> occupiedSquares, out (Position? NewPos, Position? OldPos)? pos)
        {
            pos = null;

            var bishopMove = new BishopMove();
            List<Position> possibleMoves = bishopMove.ValidMovesFor(Position).ToList();

            return TryMove(occupiedSquares, possibleMoves, ref pos);
        }
    }
}
