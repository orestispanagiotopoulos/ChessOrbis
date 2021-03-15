using ChessLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleProgram.Entities;
using System.Collections.Generic;

namespace SampleProject.Tests
{
    [TestClass]
    public class KnightTest
    {
        [TestMethod]
        public void TryMove_WhenOnlyOneAvailableMove_ThenPlayThisMove()
        {
            // Arrange
            var Initialpos = new Position(1, 1);
            var bishop = new Knight(Initialpos);

            var occupiedSquares = new List<Position>
            {
                new Position(2,3)
            };

            var onlyAvailableMoveExpected = new Position(3, 2);

            // Act
            var result = bishop.TryMove(occupiedSquares, out (Position? NewPos, Position? OldPos)? pos);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(onlyAvailableMoveExpected, pos.Value.NewPos);
            Assert.AreEqual(onlyAvailableMoveExpected, bishop.Position);
            Assert.AreEqual(Initialpos, pos.Value.OldPos);
        }

        [TestMethod]
        public void TryMove_WhenNoAvailableMove_ThenDoNotMove()
        {
            // Arrange
            var Initialpos = new Position(1, 1);
            var bishop = new Knight(Initialpos);

            var occupiedSquares = new List<Position>
            {
                new Position(2,3),
                new Position(3,2)
            };

            // Act
            var result = bishop.TryMove(occupiedSquares, out (Position? NewPos, Position? OldPos)? pos);

            // Assert
            Assert.IsFalse(result);
            Assert.IsNull(pos);
            Assert.AreEqual(Initialpos, bishop.Position);
        }
    }
}
