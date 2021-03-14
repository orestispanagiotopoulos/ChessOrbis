using ChessLib;
using NUnit.Framework;
using SampleProgram.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProgram.Test
{
    public class KnightTest
    {
        [Test]
        public void TryMove_WhenOnlyOneAvailableMove_ThenPlayThisMove()
        {
            // Arrange
            var Initialpos = new Position(1, 1);
            var bishop = new Bishop(Initialpos);

            var occupiedSquares = new List<Position>
            {
                new Position(2,3)
            };

            var onlyAvailableMoveExpected = new Position(3,2);

            // Act
            var result = bishop.TryMove(occupiedSquares, out (Position? NewPos, Position? OldPos)? pos);

            var test = pos.Value.NewPos;

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(onlyAvailableMoveExpected, pos.Value.NewPos);
            Assert.AreEqual(onlyAvailableMoveExpected, bishop.Position);
            Assert.AreEqual(Initialpos, pos.Value.OldPos);
        }
    }
}
