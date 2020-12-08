using Microsoft.VisualStudio.TestTools.UnitTesting;

using MyExel;

namespace UnitTestMyExel
{
    [TestClass]
    public class MyExelTest2
    {
        [TestMethod]
        public void ParserDiv1()
        {
            // Arrange
            string testLine = "25 div 78";
            // Act
            Parser testParser = new Parser();
            string result = testParser.Calculate(testLine);
            // Assert
            string expected = "0";
            Assert.AreEqual(expected, result, "Parser did not DIV correctly");
        }
        [TestMethod]
        public void ParserDiv2()
        {
            // Arrange
            string testLine = "78 div 25";
            // Act
            Parser testParser = new Parser();
            string result = testParser.Calculate(testLine);
            // Assert
            string expected = "3";
            Assert.AreEqual(expected, result, "Parser did not DIV correctly");
        }
        [TestMethod]
        public void ParserDiv3()
        {
            // Arrange
            string testLine = "25 div 25";
            // Act
            Parser testParser = new Parser();
            string result = testParser.Calculate(testLine);
            // Assert
            string expected = "1";
            Assert.AreEqual(expected, result, "Parser did not DIV correctly");
        }
    }
}