namespace TicTacToe.Tests
{
    using GameLogic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GameResultValidatorTests
    {
        // Horizontal tests
        [TestMethod]
        public void FirstHorizontalShouldReturnGameWonByX()
        {
            var game = "XXX------";

            var validaotor = new GameResultValidator();

            Assert.AreEqual(GameResult.WonByX, validaotor.GetResult(game));
        }

        [TestMethod]
        public void FirstHorizontalShouldReturnGameWonByO()
        {
            var game = "OOOXOXOX-";

            var validaotor = new GameResultValidator();

            Assert.AreEqual(GameResult.WonByO, validaotor.GetResult(game));
        }

        [TestMethod]
        public void SecondHorizontalShouldReturnGameWonByX()
        {
            var game = "OO-XXX---";

            var validaotor = new GameResultValidator();

            Assert.AreEqual(GameResult.WonByX, validaotor.GetResult(game));
        }

        [TestMethod]
        public void SecondHorizontalShouldReturnGameWonByO()
        {
            var game = "X--OOO-XX";

            var validaotor = new GameResultValidator();

            Assert.AreEqual(GameResult.WonByO, validaotor.GetResult(game));
        }

        [TestMethod]
        public void ThirdHorizontalShouldReturnGameWonByX()
        {
            var game = "O-OOX-XXX";

            var validaotor = new GameResultValidator();

            Assert.AreEqual(GameResult.WonByX, validaotor.GetResult(game));
        }

        [TestMethod]
        public void ThirdHorizontalShouldReturnGameWonByO()
        {
            var game = "-X-XX-OOO";

            var validaotor = new GameResultValidator();

            Assert.AreEqual(GameResult.WonByO, validaotor.GetResult(game));
        }

        // Vertical tests
        [TestMethod]
        public void FirstVerticalShouldReturnGameWonByX()
        {
            var game = "XO-XXOXO-";

            var validaotor = new GameResultValidator();

            Assert.AreEqual(GameResult.WonByX, validaotor.GetResult(game));
        }

        [TestMethod]
        public void FirstVerticalShouldReturnGameWonByO()
        {
            var game = "OX-OOXOX-";

            var validaotor = new GameResultValidator();

            Assert.AreEqual(GameResult.WonByO, validaotor.GetResult(game));
        }

        [TestMethod]
        public void SecondVerticalShouldReturnGameWonByX()
        {
            var game = "OXO-XOXX-";

            var validaotor = new GameResultValidator();

            Assert.AreEqual(GameResult.WonByX, validaotor.GetResult(game));
        }

        [TestMethod]
        public void SecondVerticalShouldReturnGameWonByO()
        {
            var game = "XOX-OXOO-";

            var validaotor = new GameResultValidator();

            Assert.AreEqual(GameResult.WonByO, validaotor.GetResult(game));
        }

        [TestMethod]
        public void ThirdVerticalShouldReturnGameWonByX()
        {
            var game = "O-XOXX-OX";

            var validaotor = new GameResultValidator();

            Assert.AreEqual(GameResult.WonByX, validaotor.GetResult(game));
        }

        [TestMethod]
        public void ThirdVerticalShouldReturnGameWonByO()
        {
            var game = "X-OXOO-XO";

            var validaotor = new GameResultValidator();

            Assert.AreEqual(GameResult.WonByO, validaotor.GetResult(game));
        }

        // Diagonal tests
        [TestMethod]
        public void FirstDiagonalShouldReturnGameWonByX()
        {
            var game = "X--OX--OX";

            var validaotor = new GameResultValidator();

            Assert.AreEqual(GameResult.WonByX, validaotor.GetResult(game));
        }

        [TestMethod]
        public void FirstDiagonalShouldReturnGameWonByO()
        {
            var game = "O---O---O";

            var validaotor = new GameResultValidator();

            Assert.AreEqual(GameResult.WonByO, validaotor.GetResult(game));
        }

        [TestMethod]
        public void SecondDiagonalShouldReturnGameWonByX()
        {
            var game = "--XOXXXOO";

            var validaotor = new GameResultValidator();

            Assert.AreEqual(GameResult.WonByX, validaotor.GetResult(game));
        }

        [TestMethod]
        public void SecondDiagonalShouldReturnGameWonByO()
        {
            var game = "--OXOOOXX";

            var validaotor = new GameResultValidator();

            Assert.AreEqual(GameResult.WonByO, validaotor.GetResult(game));
        }

        // Game not finished tests
        [TestMethod]
        public void ExpectGameNotFinishedAfterFirstMove()
        {
            var game = "X--------";

            var validaotor = new GameResultValidator();

            Assert.AreEqual(GameResult.NotFinished, validaotor.GetResult(game));
        }

        [TestMethod]
        public void ExpectGameNotFinishedWithOneMoveLeftAndNoWinner()
        {
            var game = "OXOOXXXO-";

            var validaotor = new GameResultValidator();

            Assert.AreEqual(GameResult.NotFinished, validaotor.GetResult(game));
        }

        // Game finishes without winner
        [TestMethod]
        public void ExpectDrawIfNoWinner()
        {
            var game = "OXOXXOXOX";

            var validaotor = new GameResultValidator();

            Assert.AreEqual(GameResult.Draw, validaotor.GetResult(game));
        }

        [TestMethod]
        public void ExpectDrawWithoutWinner()
        {
            var game = "OXOOXXXOO";

            var validaotor = new GameResultValidator();

            Assert.AreEqual(GameResult.Draw, validaotor.GetResult(game));
        }
    }
}