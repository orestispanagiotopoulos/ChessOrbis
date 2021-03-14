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

        public abstract bool TryMove(List<Position> occupiedSquares, out Position? newPos, out Position? oldPos);
        protected bool TryMove(List<Position> occupiedSquares, ref Position? newPos, ref Position? oldPos, List<Position> possibleMoves)
        {
            while (possibleMoves.Any())
            {
                var pos = possibleMoves[_rnd.Next(possibleMoves.Count)];

                if (!occupiedSquares.Contains(pos))
                {
                    oldPos = Position;
                    Position = pos;
                    newPos = Position;
                    return true;
                }

                possibleMoves.Remove(pos);
            }

            return false;
        }
    }
}
