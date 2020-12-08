using Microsoft.VisualStudio.TestTools.UnitTesting;

using MyExel;

namespace UnitTestMyExel
{
    [TestClass]
    public class MyExelTest3
    {
        [TestMethod]
        public void ParserLessEquals1()
        {
            // Arrange
            string testLine = "25 <= 78";
            // Act
            Parser testParser = new Parser();
            string result = testParser.Calculate(testLine);
            // Assert
            string expected = "1";
            Assert.AreEqual(expected, result, "Parser did not DIV correctly");
        }
        [TestMethod]
        public void ParserLessEquals2()
        {
            // Arrange
            string testLine = "78 <= 25";
            // Act
            Parser testParser = new Parser();
            string result = testParser.Calculate(testLine);
            // Assert
            string expected = "0";
            Assert.AreEqual(expected, result, "Parser did not DIV correctly");
        }
        [TestMethod]
        public void ParserLessEquals3()
        {
            // Arrange
            string testLine = "25 <= 25";
            // Act
            Parser testParser = new Parser();
            string result = testParser.Calculate(testLine);
            // Assert
            string expected = "1";
            Assert.AreEqual(expected, result, "Parser did not DIV correctly");
        }
    }
}