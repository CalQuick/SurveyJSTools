using System;
using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryTest
{
    [TestClass]
    public class ArrayToolsTest
    {
        [TestMethod]
        public void TrimArray()
        {
            string[] input = { " abc   ", "abc", " ab c " };
            input.TrimWhiteSpace();

            string[] expected = { "abc", "abc", "ab c" };

            for (int i = 0; i < input.Length; i++)
            {
                Assert.AreEqual(input[i], expected[i]);
            }
        }

        [TestMethod]
        public void ExtractIdFromQustion1()
        {
            string input = "q1. Question 1";
            string QuestionId;
            string outputLine;

            ArrayTools.ExtractIdFromQuestion(out QuestionId, out outputLine, input);

            Assert.AreEqual("q1", QuestionId);
            Assert.AreEqual("Question 1", outputLine);
        }

        [TestMethod]
        public void AdvanceIdTest()
        {
            string input = "q01a";
            string expected = "q02";

            ArrayTools.AdvanceId(ref input);

            Assert.AreEqual(expected, input);
        }
    }
}
