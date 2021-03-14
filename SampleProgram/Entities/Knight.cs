using ChessLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleProgram.Entities
{
    public class Knight : Piece
    {
        public Knight(Position pos) : base(pos)
        {
        }

        public override bool TryMove(List<Position> occupiedSquares, out (Position? NewPos, Position? OldPos)? pos)
        {
            pos = null;

            var knightMove = new KnightMove();
            List<Position> possibleMoves = knightMove.ValidMovesFor(Position).ToList();

            return TryMove(occupiedSquares, possibleMoves, ref pos);
        }
    }
}
