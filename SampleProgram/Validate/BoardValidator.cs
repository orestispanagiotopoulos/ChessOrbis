using ChessLib;
using SampleProgram.Enumerations;
using System;
using System.Collections.Generic;

namespace SampleProgram.Validate
{
    public class BoardValidator : IValidator
    {
        public void Validate(List<(PieceType Type, Position Pos)> pieces)
        {
            ValidatePiecePostition(pieces);
            ValidateNoPositionOvelap(pieces);
        }

        private static void ValidatePiecePostition(List<(PieceType Type, Position Pos)> Pieces)
        {
            foreach (var piece in Pieces)
            {
                if (piece.Pos.X > 8 || piece.Pos.X < 1 || piece.Pos.Y > 8 || piece.Pos.Y < 1)
                {
                    throw new ArgumentException($"The {piece.Type} has invalid position: {piece.Pos}");
                }
            }
        }

        private static void ValidateNoPositionOvelap(List<(PieceType Type, Position Pos)> Pieces)
        {
            var hs = new HashSet<Position>();

            for (var i = 0; i < Pieces.Count; ++i)
            {
                if (!hs.Add(Pieces[i].Pos))
                {
                    throw new ArgumentException($"The {Pieces[i].Type} occupied the position of another piece. " +
                        $"The dublicate positon is {Pieces[i].Pos}");
                }
            }
        }
    }
}
