﻿using ChessLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleProgram.Entities
{
    public class Queen : Piece
    {
        public Queen(Position pos) : base(pos)
        {
        }

        public override bool TryMove(List<Position> occupiedSquares, out Position? newPos, out Position? oldPos)
        {
            newPos = null;
            oldPos = null;

            var queenMove = new QueenMove();
            List<Position> possibleMoves = queenMove.ValidMovesFor(Position).ToList();

            return TryMove(occupiedSquares, ref newPos, ref oldPos, possibleMoves);
        }
    }
}
