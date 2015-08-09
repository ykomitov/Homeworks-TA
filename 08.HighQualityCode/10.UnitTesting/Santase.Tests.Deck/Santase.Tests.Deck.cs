using System;
using NUnit.Framework;
using Santase.Logic.Cards;
using Santase.Logic;

namespace Santase.Tests
{
    [TestFixture]
    public class SantaseDeckTests
    {
        [Test]
        public void NewDeckShouldHave24Cards()
        {
            Deck testDeck = new Deck();
            Assert.AreEqual(24, testDeck.CardsLeft, "The new deck should have 24 cards!");
        }

        [Test]
        public void NextCardShouldReturnAValidCard()
        {
            Deck testDeck = new Deck();
            var nextCard = testDeck.GetNextCard();

            Assert.IsTrue(Enum.IsDefined(typeof(CardSuit), nextCard.Suit), "Returned card does not have a valid suit");
            Assert.IsTrue(Enum.IsDefined(typeof(CardType), nextCard.Type), "Returned card does not have a valid type");
        }

        [TestCase(1)]
        [TestCase(10)]
        [TestCase(24)]
        public void InvokingNextCardShouldReduceTheNumberOfCardsInTheDeck(int numberOfInvocations)
        {
            Deck testDeck = new Deck();

            for (int i = 0; i < numberOfInvocations; i++)
            {
                testDeck.GetNextCard();
            }

            Assert.AreEqual(24 - numberOfInvocations, testDeck.CardsLeft);
        }

        [Test]
        public void GetTrumpCardShouldReturnTheTrumpCard()
        {
            Deck testDeck = new Deck();
            var trumpCard = testDeck.GetTrumpCard;

            for (int i = 0; i < 23; i++)
            {
                testDeck.GetNextCard();
            }

            var lastCard = testDeck.GetNextCard();

            Assert.IsTrue(lastCard.Suit == trumpCard.Suit, string.Format("Last card suit should equal trump card suit: {0} : {1}", lastCard.Suit, trumpCard.Suit, testDeck.CardsLeft));
            Assert.IsTrue(lastCard.Type == trumpCard.Type, string.Format("Last card type should equal trump card type: {0} : {1}", lastCard.Type, trumpCard.Type));
        }

        [Test]
        public void ChangeTrumpCardShouldChangeTheTrumpCard()
        {
            var testDeck = new Deck();
            var initialTrumpCard = testDeck.GetTrumpCard;
            var newTrumpCard = new Card(CardSuit.Club, CardType.Nine);

            testDeck.ChangeTrumpCard(newTrumpCard);

            Assert.AreNotSame(initialTrumpCard, testDeck.GetTrumpCard);
        }

        [Test]
        [ExpectedException(typeof(InternalGameException))]
        public void ChangeTrumpCardShouldNotChangeItWhenTheDechIsEmpty()
        {
            var testDeck = new Deck();
            var initialTrumpCard = testDeck.GetTrumpCard;
            var newTrumpCard = new Card(CardSuit.Club, CardType.Nine);

            for (int i = 0; i < 24; i++)
            {
                testDeck.GetNextCard();
            }

            testDeck.ChangeTrumpCard(newTrumpCard);
        }
    }
}
