using Microsoft.VisualStudio.TestTools.UnitTesting;

using MyExel;

namespace UnitTestMyExel
{
    [TestClass]
    public class MyExelTest1
    {
        [TestMethod]
        public void ParserSum1()
        {
            // Arrange
            string testLine = "25 + 78";
            // Act
            Parser testParser = new Parser();
            string result = testParser.Calculate(testLine);
            // Assert
            string expected = "103";
            Assert.AreEqual(expected, result, "Parser did not summarize correctly");
        }
        [TestMethod]
        public void ParserSum2()
        {
            // Arrange
            string testLine = "0 + 0";
            // Act
            Parser testParser = new Parser();
            string result = testParser.Calculate(testLine);
            // Assert
            string expected = "0";
            Assert.AreEqual(expected, result, "Parser did not summarize correctly");
        }
        [TestMethod]
        public void ParserSum3()
        {
            // Arrange
            string testLine = "0 + 9999";
            // Act
            Parser testParser = new Parser();
            string result = testParser.Calculate(testLine);
            // Assert
            string expected = "9999";
            Assert.AreEqual(expected, result, "Parser did not summarize correctly");
        }
    }
}
