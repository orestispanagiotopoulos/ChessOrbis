using System;
using System.Collections.Generic;
using System.Text;

namespace ChessLib.Test
{
    public class Factory
    {
        public static List<Position> ValidMovesForBishopAtPos_3_3()
        {
            var result = new List<Position>
            {
                new Position(4,4),
                new Position(5,5),
                new Position(6,6),
                new Position(7,7),
                new Position(8,8),

                new Position(2,2),
                new Position(1,1),

                new Position(2,4),
                new Position(1,5),

                new Position(4,2),
                new Position(5,1),
            };

            return result;
        }

        public static List<Position> ValidMovesForBishopAtPos_8_8()
        {
            var result = new List<Position>
            {
                new Position(1,1),
                new Position(2,2),
                new Position(3,3),
                new Position(4,4),
                new Position(5,5),
                new Position(6,6),
                new Position(7,7),
            };

            return result;
        }

        public static List<Position> ValidMovesForBishopAtPos_3_8()
        {
            var result = new List<Position>
            {
                new Position(1,6),
                new Position(2,7),

                new Position(4,7),
                new Position(5,6),
                new Position(6,5),
                new Position(7,4),
                new Position(8,3),
            };

            return result;
        }

        public static List<Position> ValidMovesForBishopAtPos_5_2()
        {
            var result = new List<Position>
            {
                new Position(4,1),

                new Position(6,1),
                
                new Position(6,3),
                new Position(7,4),
                new Position(8,5),

                new Position(4,3),
                new Position(3,4),
                new Position(2,5),
                new Position(1,6),
            };

            return result;
        }

        public static List<Position> ValidMovesForRookAtPos_3_3()
        {
            var result = new List<Position>
            {
                new Position(4,3),
                new Position(5,3),
                new Position(6,3),
                new Position(7,3),
                new Position(8,3),

                new Position(1,3),
                new Position(2,3),

                new Position(3,2),
                new Position(3,1),

                new Position(3,4),
                new Position(3,5),
                new Position(3,6),
                new Position(3,7),
                new Position(3,8),
            };

            return result;
        }

        public static List<Position> ValidMovesForRookAtPos_1_8()
        {
            var result = new List<Position>
            {
                new Position(1,1),
                new Position(1,2),
                new Position(1,3),
                new Position(1,4),
                new Position(1,5),
                new Position(1,6),
                new Position(1,7),

                new Position(2,8),
                new Position(3,8),
                new Position(4,8),
                new Position(5,8),
                new Position(6,8),
                new Position(7,8),
                new Position(8,8),
            };

            return result;
        }

        public static List<Position> ValidMovesForQueenAtPos_3_3()
        {
            var result = new List<Position>
            {
                // horizontal and vertical
                new Position(4,3),
                new Position(5,3),
                new Position(6,3),
                new Position(7,3),
                new Position(8,3),

                new Position(1,3),
                new Position(2,3),

                new Position(3,2),
                new Position(3,1),

                new Position(3,4),
                new Position(3,5),
                new Position(3,6),
                new Position(3,7),
                new Position(3,8),

                // diagonal
                new Position(4,4),
                new Position(5,5),
                new Position(6,6),
                new Position(7,7),
                new Position(8,8),

                new Position(2,2),
                new Position(1,1),

                new Position(2,4),
                new Position(1,5),

                new Position(4,2),
                new Position(5,1),
            };

            return result;
        }

        public static List<Position> ValidMovesForQueenAtPos_1_8()
        {
            var result = new List<Position>
            {
                // horizontal and vertical
                new Position(1,1),
                new Position(1,2),
                new Position(1,3),
                new Position(1,4),
                new Position(1,5),
                new Position(1,6),
                new Position(1,7),

                new Position(2,8),
                new Position(3,8),
                new Position(4,8),
                new Position(5,8),
                new Position(6,8),
                new Position(7,8),
                new Position(8,8),

                // diagonal
                new Position(2,7),
                new Position(3,6),
                new Position(4,5),
                new Position(5,4),
                new Position(6,3),

                new Position(7,2),
                new Position(8,1),
            };

            return result;
        }
    }
}
