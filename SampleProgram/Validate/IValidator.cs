using ChessLib;
using SampleProgram.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleProgram.Validate
{
    public interface IValidator
    {
        void Validate(List<(PieceType Type, Position Pos)> Pieces);
    }
}
