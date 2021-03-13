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
    }

}
