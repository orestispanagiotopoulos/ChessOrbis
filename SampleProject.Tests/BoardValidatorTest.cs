using ChessLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleProgram.Enumerations;
using SampleProgram.Validate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.Tests
{
    [TestClass]
    public class BoardValidatorTest
    {
        [TestMethod]
        public void ValidateNoPositionOvelap_WhenPiecesOverlapping_ThenThrowException()
        {
            // Arrange
            var input = new List<(PieceType Type, Position Pos)>()
            {
                (PieceType.Knight, new Position(7, 7)),
                (PieceType.Knight, new Position(7, 7)),
            };

            var validator = new BoardValidator();

            try
            {
                // Act
                validator.Validate(input);
                Assert.Fail();
            }

            catch(ArgumentException e)
            {
                // Assert
                Assert.AreEqual("The Knight occupied the position of another piece. The dublicate positon is 7,7", e.Message);
            }
            catch(Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ValidateNoPositionOvelap_WhenNoValidPiecePositionX_ThenThrowException()
        {
            // Arrange
            var input = new List<(PieceType Type, Position Pos)>()
            {
                (PieceType.Knight, new Position(9, 7)),
            };

            var validator = new BoardValidator();

            try
            {
                // Act
                validator.Validate(input);
                Assert.Fail();
            }

            catch (ArgumentException e)
            {
                // Assert
                Assert.AreEqual("The Knight has invalid position: 9,7", e.Message);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ValidateNoPositionOvelap_WhenNoValidPiecePositionY_ThenThrowException()
        {
            // Arrange
            var input = new List<(PieceType Type, Position Pos)>()
            {
                (PieceType.Knight, new Position(8, 0)),
            };

            var validator = new BoardValidator();

            try
            {
                // Act
                validator.Validate(input);
                Assert.Fail();
            }

            catch (ArgumentException e)
            {
                // Assert
                Assert.AreEqual("The Knight has invalid position: 8,0", e.Message);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ValidateNoPositionOvelap_WhenValidData_ThenPassValidation()
        {
            // Arrange
            var input = new List<(PieceType Type, Position Pos)>()
            {
                (PieceType.Knight, new Position(8, 8)),
                (PieceType.Knight, new Position(1, 1)),
            };

            var validator = new BoardValidator();

            // Act
            validator.Validate(input);
        }
    }
}
