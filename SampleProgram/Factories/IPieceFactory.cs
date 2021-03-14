using ChessLib;
using SampleProgram.Entities;
using SampleProgram.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleProgram.Factories
{
    public interface IPieceFactory
    {
        Piece CreatePiece((PieceType Type, Position Pos) Piece);
    }
}
