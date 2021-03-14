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

        public override bool TryMove(List<Position> occupiedSquares, out Position? newPos, out Position? oldPos)
        {
            newPos = null;
            oldPos = null;

            var knightMove = new KnightMove();
            List<Position> possibleMoves = knightMove.ValidMovesFor(Position).ToList();

            return TryMove(occupiedSquares, ref newPos, ref oldPos, possibleMoves);
        }
    }
}
