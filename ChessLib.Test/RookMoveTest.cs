using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessLib.Test
{
    public class RookMoveTest
    {
        [Test]
        public void ValidMovesFor_WhenRookMoveFromInsideBoard_ThenReturnValidMoves()
        {
            // Arrange
            var pos = new Position(3, 3);
            var rookMove = new RookMove();
            var expectedMoves = Factory.ValidMovesForRookAtPos_3_3();

            // Act
            var moves = rookMove.ValidMovesFor(pos).ToArray();

            // Assert
            Assert.IsNotNull(moves);
            Assert.AreEqual(14, moves.Length);

            moves.Should().BeEquivalentTo(expectedMoves);
        }

        [Test]
        public void ValidMovesFor_WhenRookMoveFromCorner_ThenReturnValidMoves()
        {
            // Arrange
            var pos = new Position(1, 8);
            var rookMove = new RookMove();
            var expectedMoves = Factory.ValidMovesForRookAtPos_1_8();

            // Act
            var moves = rookMove.ValidMovesFor(pos).ToArray();

            // Assert
            Assert.IsNotNull(moves);
            Assert.AreEqual(14, moves.Length);

            moves.Should().BeEquivalentTo(expectedMoves);
        }
    }
}
