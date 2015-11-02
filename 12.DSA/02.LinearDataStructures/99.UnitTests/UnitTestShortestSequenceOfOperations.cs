namespace _99.UnitTests
{
    using System.Linq;
    using _10.ShortestSequenceOfOperations;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Summary description for UnitTestShortestSequenceOfOperations
    /// </summary>
    [TestClass]
    public class UnitTestShortestSequenceOfOperations
    {
        [TestMethod]
        public void TestingTheExampleShouldReturnProperResult()
        {
            var n = 5;
            var m = 16;

            // Sequence: 5 → 7 → 8 → 16
            var result = FindShortestSequenceOfOperations.ShortestSequenceOfOperations(n, m);

            Assert.AreEqual(4, result.Count());
        }

        [TestMethod]
        public void NegativeStartShouldReturnProperResult()
        {
            var n = -5;
            var m = 16;

            // Sequence: -5 → -3 → -1 → 1 → 3 → 4 → 8 → 16
            var result = FindShortestSequenceOfOperations.ShortestSequenceOfOperations(n, m);

            Assert.AreEqual(8, result.Count());
        }

        [TestMethod]
        public void SpecialCaseNegativeStartShouldReturnProperResult()
        {
            var n = -2;
            var m = 2;

            // Sequence: -2 → 0 → 2
            var result = FindShortestSequenceOfOperations.ShortestSequenceOfOperations(n, m);

            Assert.AreEqual(3, result.Count());
        }

        [TestMethod]
        public void SpecialCaseNegativeStartEnd21ShouldReturnProperResult()
        {
            var n = -3;
            var m = 21;

            // Sequence: -3 → -1 → 1 → 3 → 5 → 10 → 20 → 21
            var result = FindShortestSequenceOfOperations.ShortestSequenceOfOperations(n, m);

            Assert.AreEqual(8, result.Count());
        }

        [TestMethod]
        public void SpecialCaseNegativeStartNegativeEnd()
        {
            var n = -3;
            var m = -1;

            // Sequence: -3 → -1
            var result = FindShortestSequenceOfOperations.ShortestSequenceOfOperations(n, m);

            Assert.AreEqual(2, result.Count());
        }

        [TestMethod]
        public void SpecialCaseNegativeStartNegativeEndRangeOne()
        {
            var n = -2;
            var m = -1;

            // Sequence: -2 → -1
            var result = FindShortestSequenceOfOperations.ShortestSequenceOfOperations(n, m);

            Assert.AreEqual(2, result.Count());
        }

        [TestMethod]
        public void CasePositiveStartPositiveEndRangeOne()
        {
            var n = 3;
            var m = 6;

            // Sequence: 3 → 6
            var result = FindShortestSequenceOfOperations.ShortestSequenceOfOperations(n, m);

            Assert.AreEqual(2, result.Count());
        }

        [TestMethod]
        public void CaseZeroStartPositiveEndRangeEleven()
        {
            var n = 0;
            var m = 11;

            // Sequence: 0 → 2 → 4 → 5 → 10 → 11
            var result = FindShortestSequenceOfOperations.ShortestSequenceOfOperations(n, m);

            Assert.AreEqual(6, result.Count());
        }

        [TestMethod]
        public void StartAfterEndShouldReturnEmptyCollection()
        {
            var n = 101;
            var m = 11;

            var result = FindShortestSequenceOfOperations.ShortestSequenceOfOperations(n, m);

            Assert.AreEqual(0, result.Count());
        }

        // Sorry, no time to split the tests. Be graceful ;)
        [TestMethod]
        public void PileOfTestsForDesert()
        {
            var n = 11;
            var m = 101;

            // Sequence: 11 → 12 → 24 → 25 → 50 → 100 → 101
            var result = FindShortestSequenceOfOperations.ShortestSequenceOfOperations(n, m);

            Assert.AreEqual(7, result.Count());

            var a = -11;
            var b = 0;

            // Sequence: -11 → -9 → -7 → -5 → -3 → -1 → 0
            var result2 = FindShortestSequenceOfOperations.ShortestSequenceOfOperations(a, b);
            Assert.AreEqual(7, result2.Count());

            var c = 0;
            var d = 1;

            var result3 = FindShortestSequenceOfOperations.ShortestSequenceOfOperations(c, d);
            Assert.AreEqual(2, result3.Count());

            var e = 0;
            var f = 2;

            var result4 = FindShortestSequenceOfOperations.ShortestSequenceOfOperations(e, f);
            Assert.AreEqual(2, result4.Count());

            var g = 0;
            var h = 3;

            var result5 = FindShortestSequenceOfOperations.ShortestSequenceOfOperations(g, h);
            Assert.AreEqual(3, result5.Count());

            var i = 0;
            var j = 4;

            var result6 = FindShortestSequenceOfOperations.ShortestSequenceOfOperations(i, j);
            Assert.AreEqual(3, result6.Count());
        }
    }
}
