namespace _99.UnitTests
{
    using System.Collections.Generic;
    using _04.LongestSubsequence;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTestLongestSubsequence
    {
        [TestMethod]
        public void FindingSubsequenceInTheBeginningOfTheListShouldWork()
        {
            var testList = new List<int> { 1, 1, 1, 1, 1, 2, 2, 2, 0, 0, 0, 0 };

            var result = LongestSubsequence.FindLongestSubsequence(testList);

            CollectionAssert.AreEqual(new List<int> { 1, 1, 1, 1, 1 }, result);
        }

        [TestMethod]
        public void FindingSubsequenceInTheEndOfTheListShouldWork()
        {
            var testList = new List<double> { 1, 2, 2, 0.5, 0.5, 0.5, 0.5 };

            var result = LongestSubsequence.FindLongestSubsequence(testList);

            CollectionAssert.AreEqual(new List<double> { 0.5, 0.5, 0.5, 0.5 }, result);
        }

        [TestMethod]
        public void FindingSubsequenceInTheMiddleOfTheListShouldWork()
        {
            var testList = new List<decimal> { 1, 2, 4, 4, 4, 4, 4, 4, 2, 0.5m, 0.5m, 0.5m, 0.5m };

            var result = LongestSubsequence.FindLongestSubsequence(testList);

            CollectionAssert.AreEqual(new List<decimal> { 4, 4, 4, 4, 4, 4 }, result);
        }

        [TestMethod]
        public void FindingSubsequenceShouldWorkWithNegativeNumbers()
        {
            var testList = new List<float> { 1, 2, 4, 4, 4, 2, -0.5f, -0.5f, -0.5f, -0.5f };

            var result = LongestSubsequence.FindLongestSubsequence(testList);

            CollectionAssert.AreEqual(new List<float> { -0.5f, -0.5f, -0.5f, -0.5f }, result);
        }
    }
}
