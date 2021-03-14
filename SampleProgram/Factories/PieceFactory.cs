using ChessLib;
using SampleProgram.Entities;
using SampleProgram.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleProgram.Factories
{
    public class PieceFactory : IPieceFactory
    {
        public Piece CreatePiece((PieceType Type, Position Pos) Piece)
        {
            Piece result;

            switch (Piece.Type)
            {
                case PieceType.Queen:
                    result =  new Queen(Piece.Pos);
                    break;
                case PieceType.Bishop:
                    result = new Bishop(Piece.Pos);
                    break;
                case PieceType.Knight:
                    result = new Knight(Piece.Pos);
                    break;
                default:
                    throw new InvalidOperationException($"Unknown piece: {Piece.Type}");
            }

            return result;
        }
    }
}
