using ChessLib;
using SampleProgram.Entities;
using SampleProgram.Enumerations;
using SampleProgram.Factories;
using SampleProgram.Validate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SampleProgram
{

    public class ComplexGame
    {
        private Board _board;

        public void Setup()
        {
            _board = new Board(new PieceFactory(), new BoardValidator());

            _board.SetBoard(new List<(PieceType Type, Position Pos)>
            {
                (PieceType.Knight, new Position(3,3)),
                (PieceType.Bishop, new Position(4,5)),
                (PieceType.Queen, new Position(5,6)),
            });

            // _board.SetRandomBoard(10);
        }

        public void Play(int moves)
        {
            PrintInitialPosition();

            for (var i = 1; i <= moves; i++)
            {
                if (_board.TryMoveRandomPiece(out string output))
                {
                    Console.WriteLine(output);
                }
                else
                {
                    Console.WriteLine("There are no legal moves");
                    break;
                }
            }
        }

        private void PrintInitialPosition()
        {
            Console.WriteLine("Initial position:");

            var i = 1;
            foreach (var piece in _board.Pieces.OrderBy(x => x.GetType().Name))
            {
                Console.WriteLine($"{i}. {piece.GetType().Name} at {piece.Position}");
                i++;
            }
            Console.WriteLine();
        }
    }

}
