using SampleProgram.Entities;
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
            _board = new Board();
            _board.SetRandomBoard(10);
        }

        public void Play(int moves)
        {
            for(var i = 1; i<= moves; i++)
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

            Console.ReadLine();
        }
    }

}
