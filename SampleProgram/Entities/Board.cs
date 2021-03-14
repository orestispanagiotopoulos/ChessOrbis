using ChessLib;
using SampleProgram.Enumerations;
using SampleProgram.Extentions;
using System;
using System.Collections.Generic;

namespace SampleProgram.Entities
{
    public class Board
    {
        private readonly Random _rnd = new Random();
        public List<Piece> Pieces { get; private set; } = new List<Piece>();


        public void SetRandomBoard(int numberOfPieces)
        {
            if(numberOfPieces < 1 || numberOfPieces > 64)
            {
                throw new ArgumentException($"Invalid number of pieces {numberOfPieces}");
            }

            var boardSquares = GetBoardSquares();
            boardSquares.Shuffle(); // randomly re-arrange the list of the squares.

            for (var i = 0; i < numberOfPieces; i++)
            {
                PieceType piece = GetRandomPiece();

                //var numberOfAvailablePieces = GetNumberOfAvailablePieces();
                //var piece = GetRandomPiece(numberOfAvailablePieces);

                switch (piece)
                {
                    case PieceType.Queen:
                        Pieces.Add(new Queen(new Position(boardSquares[i].X, boardSquares[i].Y)));
                        break;
                    case PieceType.Bishop:
                        Pieces.Add(new Bishop(new Position(boardSquares[i].X, boardSquares[i].Y)));
                        break;
                    case PieceType.Knight:
                        Pieces.Add(new Knight(new Position(boardSquares[i].X, boardSquares[i].Y)));
                        break;
                    default:
                        throw new InvalidOperationException($"Unknown piece: {piece}");
                }
            }
        }

        public bool TryMoveRandomPiece(out string output)
        {
            output = string.Empty;

            Pieces.Shuffle();

            foreach(var p in Pieces)
            {
                if( p.TryMove(GetOccupiedSquares(), out Position? newPos, out Position? oldPos))
                {
                    var piece = p.GetType().Name;
                    output = $"Move {piece} from {oldPos} to {newPos.ToString()}" ;
                    return true;
                }
            }

            return false;
        }

        private List<Position> GetOccupiedSquares()
        {
            var result = new List<Position>();

            foreach(var p in Pieces)
            {
                result.Add(p.Position);
            }

            return result;
        }

        //public void SetBoardWith3Pieces()
        //{
        //    Pieces = new List<Piece>
        //    {
        //        new Queen(new Position(3,3)),
        //        new Queen(new Position(5,5)),
        //        new Queen(new Position(7,7)),
        //    };
        //}

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

        //private static int GetNumberOfAvailablePieces()
        //{
        //    return Enum.GetNames(typeof(PieceType)).Length;
        //}

        //private PieceType GetRandomPiece(int numberOfAvailablePieces)
        //{
        //    return (PieceType)_rnd.Next(numberOfAvailablePieces);
        //}
    }
}
