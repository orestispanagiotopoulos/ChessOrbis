using ChessLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleProgram.Entities
{
    public abstract class Piece
    {
        private readonly Random _rnd = new Random();
        public Position Position { get; private set; }

        protected Piece(Position pos)
        {
            Position = pos;
        }

        public abstract bool TryMove(List<Position> occupiedSquares, out (Position? NewPos, Position? OldPos)? pos);
        protected bool TryMove(List<Position> occupiedSquares, List<Position> possibleMoves, ref (Position? NewPos, Position? OldPos)? pos)
        {
            while (possibleMoves.Any())
            {
                var possibleMove = possibleMoves[_rnd.Next(possibleMoves.Count)];

                if (!occupiedSquares.Contains(possibleMove))
                {
                    pos = (possibleMove, Position);
                    Position = possibleMove;
                    return true;
                }

                possibleMoves.Remove(possibleMove);
            }

            return false;
        }
    }
}
