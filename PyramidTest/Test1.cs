using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pyramid;
using System;

namespace PyramidTest
{
    [TestClass]
    public class PyramidTest
    {
        [TestMethod]
        [DataRow(0, "")]
        [DataRow(1, "*\n")]
        [DataRow(3, "*\n**\n***\n")]
        [DataRow(5, "*\n**\n***\n****\n*****\n")]
        public void ReverseMarioStairs_ProducesCorrectOutput(int input, string expected)
        {
            // Arrange
            var patternGenerator = new PatternGenerator();

            // Act
            string actual = patternGenerator.ReverseMarioStairs(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(0, "")]
        [DataRow(1, "*\n")]
        [DataRow(3, "  *\n **\n***\n")]
        [DataRow(5, "    *\n   **\n  ***\n ****\n*****\n")]
        public void MarioStairs_ProducesCorrectOutput(int input, string expected)
        {
            // Arrange
            var patternGenerator = new PatternGenerator();

            // Act
            string actual = patternGenerator.MarioStairs(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(0, "")]
        [DataRow(1, "*\n")]
        [DataRow(3, "  *\n ***\n*****\n")]
        [DataRow(5, "    *\n   ***\n  *****\n *******\n*********\n")]
        public void Pyramid_ProducesCorrectOutput(int input, string expected)
        {
            // Arrange
            var patternGenerator = new PatternGenerator();
            // Act
            string actual = patternGenerator.Pyramid(input);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(0, "")]
        [DataRow(1, "*\n")]
        [DataRow(2, " *\n* *\n")]
        [DataRow(3, "  *\n * *\n* * *\n")]
        [DataRow(4, "   *\n  * *\n * * *\n* * * *\n")]
        [DataRow(9, "        *\n       * *\n      * * *\n     * * * *\n    * * * * *\n   * * * * * *\n  * * * * * * *\n * * * * * * * *\n* * * * * * * * *\n")]
        public void SteepPyramid_ProducesCorrectOutput(int input, string expected)
        {
            // Arrange
            var patternGenerator = new PatternGenerator();
            // Act
            string actual = patternGenerator.SteepPyramid(input);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(0, "")]
        [DataRow(1, "*\n")]
        [DataRow(2, " *\n* *\n *\n")]
        [DataRow(3, "  *\n * *\n* * *\n * *\n  *\n")]
        [DataRow(4, "   *\n  * *\n * * *\n* * * *\n * * *\n  * *\n   *\n")]
        [DataRow(5, "    *\n   * *\n  * * *\n * * * *\n* * * * *\n * * * *\n  * * *\n   * *\n    *\n")]
        public void Diamond_ProducesCorrectOutput(int input, string expected)
        {
            // Arrange
            var patternGenerator = new PatternGenerator();
            // Act
            string actual = patternGenerator.Diamond(input);
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
