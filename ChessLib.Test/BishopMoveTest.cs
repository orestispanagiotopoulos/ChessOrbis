using FluentAssertions;
using NUnit.Framework;
using System.Linq;

namespace ChessLib.Test
{
    public class BishopMoveTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidMovesFor_WhenBishopMoveFromInsideBoard_ThenReturnValidMoves()
        {
            // Arrange
            var pos = new Position(3, 3);
            var bishopMove = new BishopMove();
            var expectedMoves = Factory.ValidMovesForBishopAtPos_3_3();

            // Act
            var moves = bishopMove.ValidMovesFor(pos).ToArray();

            // Assert
            Assert.IsNotNull(moves);
            Assert.AreEqual(11, moves.Length);

            moves.Should().BeEquivalentTo(expectedMoves);
        }

        [Test]
        public void ValidMovesFor_WhenBishopMoveFromTopRightCorner_ThenReturnValidMoves()
        {
            // Arrange
            var pos = new Position(8, 8);
            var bishopMove = new BishopMove();
            var expectedMoves = Factory.ValidMovesForBishopAtPos_8_8();

            // Act
            var moves = bishopMove.ValidMovesFor(pos).ToArray();

            // Assert
            Assert.IsNotNull(moves);
            Assert.AreEqual(7, moves.Length);

            moves.Should().BeEquivalentTo(expectedMoves);
        }

        [Test]
        public void ValidMovesFor_WhenBishopMoveFromTopOfTheBoard_ThenReturnValidMoves()
        {
            // Arrange
            var pos = new Position(3, 8);
            var bishopMove = new BishopMove();
            var expectedMoves = Factory.ValidMovesForBishopAtPos_3_8();

            // Act
            var moves = bishopMove.ValidMovesFor(pos).ToArray();

            // Assert
            Assert.IsNotNull(moves);
            Assert.AreEqual(7, moves.Length);

            moves.Should().BeEquivalentTo(expectedMoves);
        }

        [Test]
        public void ValidMovesFor_WhenBishopMoveFromSecondRow_ThenReturnValidMoves()
        {
            // Arrange
            var pos = new Position(5, 2);
            var bishopMove = new BishopMove();
            var expectedMoves = Factory.ValidMovesForBishopAtPos_5_2();

            // Act
            var moves = bishopMove.ValidMovesFor(pos).ToArray();

            // Assert
            Assert.IsNotNull(moves);
            Assert.AreEqual(9, moves.Length);

            moves.Should().BeEquivalentTo(expectedMoves);
        }
    }
}