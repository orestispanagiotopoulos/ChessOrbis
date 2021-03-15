using ChessLib;
using SampleProgram.Enumerations;
using SampleProgram.Extentions;
using SampleProgram.Factories;
using SampleProgram.Validate;
using System;
using System.Collections.Generic;

namespace SampleProgram.Entities
{
    public class Board
    {
        private readonly Random _rnd = new Random();
        private readonly IPieceFactory _pieceFactory;
        private readonly IValidator _validator;

        public List<Piece> Pieces { get; private set; } = new List<Piece>();

        public Board(IPieceFactory pieceFactory, IValidator validator)
        {
            _pieceFactory = pieceFactory;
            _validator = validator;
        }

        public void SetBoard(List<(PieceType Type, Position Pos)> pieces)
        {
            _validator.Validate(pieces);

            foreach(var piece in pieces)
            {
                Pieces.Add(_pieceFactory.CreatePiece(piece));
            }
        }

        /// <summary>
        /// This method is not used currently but is another option to initialize the board with a predefined number of pieces. 
        /// This method is adding the specified number of random pieces in random initial positions.
        /// </summary>
        /// <param name="numberOfPieces"></param>
        public void SetRandomBoard(int numberOfPieces)
        {
            if(numberOfPieces < 1 || numberOfPieces > 64)
            {
                throw new ArgumentException($"Invalid number of pieces: {numberOfPieces}");
            }

            var boardSquares = GetBoardSquares();
            boardSquares.Shuffle(); // randomly re-arrange the list of the squares.

            for (var i = 0; i < numberOfPieces; i++)
            {
                PieceType piece = GetRandomPiece();
                Pieces.Add(_pieceFactory.CreatePiece((piece, new Position(boardSquares[i].X, boardSquares[i].Y))));
            }
        }

        public bool TryMoveRandomPiece(out string output)
        {
            output = string.Empty;

            Pieces.Shuffle();

            foreach(var piece in Pieces)
            {
                if(piece.TryMove(GetOccupiedSquares(), out (Position? NewPos, Position? OldPos)? pos))
                {
                    var pieceName = piece.GetType().Name;
                    output = $"Move {pieceName} from {pos.Value.OldPos} to {pos.Value.NewPos}" ;

                    return true;
                }
            }

            return false;
        }

        private List<Position> GetOccupiedSquares()
        {
            var result = new List<Position>();

            foreach(var piece in Pieces)
            {
                result.Add(piece.Position);
            }

            return result;
        }

        private List<(int X,int Y)> GetBoardSquares()
        {
            var result = new List<(int, int)>();

            for (var i = 1; i<=8; i++)
            {
                for (var j = 1; j <= 8; j++)
                {
                    result.Add((i, j));
                }
            }

            return result;
        }

        private PieceType GetRandomPiece()
        {
            var values = Enum.GetValues(typeof(PieceType));
            PieceType piece = (PieceType)values.GetValue(_rnd.Next(values.Length));
            return piece;
        }
    }
}
