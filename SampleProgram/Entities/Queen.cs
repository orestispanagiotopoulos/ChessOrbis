using ChessLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleProgram.Entities
{
    public class Queen : Piece
    {
        public Position Position { get; set; }
        public Queen(Position pos)
        {
            Position = pos;
        }

        public void Move()
        {
            var queenMove = new QueenMove();
            var possibleMoves = queenMove.ValidMovesFor(Position).ToArray();
        }
    }
}
