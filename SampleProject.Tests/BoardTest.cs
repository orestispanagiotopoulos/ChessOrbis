using ChessLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleProgram.Entities;
using SampleProgram.Enumerations;
using SampleProgram.Factories;
using SampleProgram.Validate;
using System.Collections.Generic;

namespace SampleProject.Tests
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void TryMoveRandomPiece_WhenOnlyOneAvailableMove_ThenPlayThisMove()
        {
            // Arrange
            var board = new Board(new PieceFactory(), new BoardValidator());
            var input = CreateInputWithOnlyOneAvailableMove();

            board.SetBoard(input);

            // Act
            var result = board.TryMoveRandomPiece(out string output);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual("Move Bishop from 2,2 to 1,1", output);
        }

        [TestMethod]
        public void TryMoveRandomPiece_WhenNoAvailableMove_ThenReturnFalse()
        {
            // Arrange
            var board = new Board(new PieceFactory(), new BoardValidator());
            var input = CreateInputWithNoAvailableMove();

            board.SetBoard(input);

            // Act
            var result = board.TryMoveRandomPiece(out string output);

            // Assert
            Assert.IsFalse(result);
            Assert.AreEqual(string.Empty, output);
        }

        private List<(PieceType Type, Position Pos)> CreateInputWithOnlyOneAvailableMove()
        {
            var testInput = new List<(PieceType Type, Position Pos)>();

            for (var i = 1; i <= 8; i++)
            {
                for (var j = 1; j <= 8; j++)
                {
                    if (i == j && i == 1)
                    {
                        continue; // The only empty square
                    }
                    else if (i==j && (i>=3))
                    {
                        testInput.Add((PieceType.Knight, new Position(i, j)));
                    }
                    else
                    {
                        testInput.Add((PieceType.Bishop, new Position(i, j)));
                    }
                }
            }

            return testInput;
        }

        private List<(PieceType Type, Position Pos)> CreateInputWithNoAvailableMove()
        {
            var testInput = new List<(PieceType Type, Position Pos)>();

            for (var i = 1; i <= 8; i++)
            {
                for (var j = 1; j <= 8; j++)
                {
                    testInput.Add((PieceType.Queen, new Position(i, j)));
                }
            }

            return testInput;
        }
    }
}
