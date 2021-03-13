using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessLib.Test
{
    public class QueenMoveTest
    {
        [Test]
        public void ValidMovesFor_WhenQueenMoveFromInsideBoard_ThenReturnValidMoves()
        {
            // Arrange
            var pos = new Position(3, 3);
            var queenMove = new QueenMove();
            var expectedMoves = Factory.ValidMovesForQueenAtPos_3_3();

            // Act
            var moves = queenMove.ValidMovesFor(pos).ToArray();

            // Assert
            Assert.IsNotNull(moves);
            Assert.AreEqual(25, moves.Length);

            moves.Should().BeEquivalentTo(expectedMoves);
        }

        [Test]
        public void ValidMovesFor_WhenQueenMoveFromtheCorner_ThenReturnValidMoves()
        {
            // Arrange
            var pos = new Position(1, 8);
            var queenMove = new QueenMove();
            var expectedMoves = Factory.ValidMovesForQueenAtPos_1_8();

            // Act
            var moves = queenMove.ValidMovesFor(pos).ToArray();

            // Assert
            Assert.IsNotNull(moves);
            Assert.AreEqual(21, moves.Length);

            moves.Should().BeEquivalentTo(expectedMoves);
        }
    }
}
