using System.Collections.Generic;
using NUnit.Framework;

namespace PokerHands.Tests
{
    [TestFixture]
    public class PokerHandsScorerTests
    {
        [Test]
        public void Score_WhenOnePlayerHasAStraightFlushAndTheOtherHasAFourOfAKind_TheStraightFlushWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "White");
            Assert.AreEqual(actualResult.HandType, HandType.StraightFlush);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Five);
        }

        [Test]
        public void Score_WhenOnePlayerHasAStraightFlushAndTheOtherHasAFullHouse_TheStraightFlushWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Six, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "White");
            Assert.AreEqual(actualResult.HandType, HandType.StraightFlush);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Seven);
        }

        [Test]
        public void Score_WhenOnePlayerHasAStraightFlushAndTheOtherHasAFlush_TheStraightFlushWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Six, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Ten, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.King, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Clubs}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "White");
            Assert.AreEqual(actualResult.HandType, HandType.StraightFlush);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Ace);
        }

        [Test]
        public void Score_WhenOnePlayerHasAStraightFlushAndTheOtherHasAStraight_TheStraightFlushWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Ten, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.King, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Six, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "White");
            Assert.AreEqual(actualResult.HandType, HandType.StraightFlush);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Seven);
        }

        [Test]
        public void Score_WhenOnePlayerHasAStraightFlushAndTheOtherHasAThreeOfAKind_TheStraightFlushWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.King, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "White");
            Assert.AreEqual(actualResult.HandType, HandType.StraightFlush);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Five);
        }

        [Test]
        public void Score_WhenOnePlayerHasAStraightFlushAndTheOtherHasTwoPairs_TheStraightFlushWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "White");
            Assert.AreEqual(actualResult.HandType, HandType.StraightFlush);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Five);
        }

        [Test]
        public void Score_WhenOnePlayerHasAStraightFlushAndTheOtherHasAPair_TheStraightFlushWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Six, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "White");
            Assert.AreEqual(actualResult.HandType, HandType.StraightFlush);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Six);
        }

        [Test]
        public void Score_WhenOnePlayerHasAFourOfAKindAndTheOtherHasAFullHouse_TheFourOfAKindWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Hearts}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "Black");
            Assert.AreEqual(actualResult.HandType, HandType.FourOfAKind);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Nine);
        }

        [Test]
        public void Score_WhenOnePlayerHasAFourOfAKindAndTheOtherHasAFlush_TheFourOfAKindWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "Black");
            Assert.AreEqual(actualResult.HandType, HandType.FourOfAKind);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Nine);
        }

        [Test]
        public void Score_WhenOnePlayerHasAFourOfAKindAndTheOtherHasAStraight_TheFourOfAKindWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Clubs}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "Black");
            Assert.AreEqual(actualResult.HandType, HandType.FourOfAKind);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Nine);
        }

        [Test]
        public void Score_WhenOnePlayerHasAFourOfAKindAndTheOtherHasAThreeOfAKind_TheFourOfAKindWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "Black");
            Assert.AreEqual(actualResult.HandType, HandType.FourOfAKind);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Nine);
        }

        [Test]
        public void Score_WhenOnePlayerHasAFourOfAKindAndTheOtherHasTwoPairs_TheFourOfAKindWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "Black");
            Assert.AreEqual(actualResult.HandType, HandType.FourOfAKind);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Nine);
        }

        [Test]
        public void Score_WhenOnePlayerHasAFourOfAKindAndTheOtherHasAPair_TheFourOfAKindWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Diamonds}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "Black");
            Assert.AreEqual(actualResult.HandType, HandType.FourOfAKind);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Nine);
        }

        [Test]
        public void Score_WhenOnePlayerHasAFullHouseAndTheOtherHasAFlush_TheFullHouseWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Diamonds}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "White");
            Assert.AreEqual(actualResult.HandType, HandType.FullHouse);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Ace);
        }

        [Test]
        public void Score_WhenOnePlayerHasAFullHouseAndTheOtherHasAStraight_TheFullHouseWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Ten, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.King, Suit = Suit.Spades}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "White");
            Assert.AreEqual(actualResult.HandType, HandType.FullHouse);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Ace);
        }

        [Test]
        public void Score_WhenOnePlayerHasAFullHouseAndTheOtherHasAThreeOfAKind_TheFullHouseWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Diamonds}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "White");
            Assert.AreEqual(actualResult.HandType, HandType.FullHouse);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Ace);
        }

        [Test]
        public void Score_WhenOnePlayerHasAFullHouseAndTheOtherHasTwoPairs_TheFullHouseWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Diamonds}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "White");
            Assert.AreEqual(actualResult.HandType, HandType.FullHouse);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Ace);
        }

        [Test]
        public void Score_WhenOnePlayerHasAFullHouseAndTheOtherHasAPair_TheFullHouseWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Hearts}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "White");
            Assert.AreEqual(actualResult.HandType, HandType.FullHouse);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Ace);
        }

        [Test]
        public void Score_WhenOnePlayerHasAFlushAndTheOtherHasAStraight_TheFlushWins()
        {   
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Diamonds}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "Black");
            Assert.AreEqual(actualResult.HandType, HandType.Flush);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Queen);
        }

        [Test]
        public void Score_WhenOnePlayerHasAFlushAndTheOtherHasAThreeOfAKind_TheFlushWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Diamonds}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "Black");
            Assert.AreEqual(actualResult.HandType, HandType.Flush);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Queen);
        }

        [Test]
        public void Score_WhenOnePlayerHasAFlushAndTheOtherHasTwoPairs_TheFlushWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Diamonds}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "Black");
            Assert.AreEqual(actualResult.HandType, HandType.Flush);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Queen);
        }

        [Test]
        public void Score_WhenOnePlayerHasAFlushAndTheOtherHasAPair_TheFlushWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Diamonds}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "Black");
            Assert.AreEqual(actualResult.HandType, HandType.Flush);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Queen);
        }

        [Test]
        public void Score_WhenOnePlayerHasAStraightAndTheOtherHasAThreeOfAKind_TheStraightWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Diamonds}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Six, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "White");
            Assert.AreEqual(actualResult.HandType, HandType.Straight);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Six);
        }

        [Test]
        public void Score_WhenOnePlayerHasAStraightAndTheOtherHasTwoPairs_TheStraightWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Diamonds}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Six, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "White");
            Assert.AreEqual(actualResult.HandType, HandType.Straight);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Six);
        }

        [Test]
        public void Score_WhenOnePlayerHasAStraightAndTheOtherHasAPair_TheStraightWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.King, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Diamonds}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Six, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "White");
            Assert.AreEqual(actualResult.HandType, HandType.Straight);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Six);
        }

        [Test]
        public void Score_WhenOnePlayerHasAThreeOfAKindAndTheOtherHasTwoPairs_TheThreeOfAKindWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Diamonds}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Six, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Six, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Six, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "White");
            Assert.AreEqual(actualResult.HandType, HandType.ThreeOfAKind);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Six);
        }

        [Test]
        public void Score_WhenOnePlayerHasAThreeOfAKindAndTheOtherHasAPair_TheThreeOfAKindWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Diamonds}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Six, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Six, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "Black");
            Assert.AreEqual(actualResult.HandType, HandType.ThreeOfAKind);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Queen);
        }

        [Test]
        public void Score_WhenOnePlayerHasTwoPairsAndTheOtherHasAPair_TheTwoPairsWin()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Diamonds}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Six, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Six, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "Black");
            Assert.AreEqual(actualResult.HandType, HandType.TwoPairs);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Queen);
        }

        [Test]
        public void Score_WhenBothPlayersHaveAHighCardAndTheValuesAreAllEqual_ItIsATie()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Two, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Hearts}
                    }
                });

            Assert.IsNull(actualResult.Winner);
            Assert.AreEqual(actualResult.HandType, HandType.HighCard);
            Assert.IsTrue(actualResult.IsTie);
            Assert.IsNull(actualResult.WinningCardValue);
        }

        [Test]
        public void Score_WhenBothPlayersHaveAHighCardButOneHasAHigherFirstCard_ThatPlayerWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Ten, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.King, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.King, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Ten, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "White");
            Assert.AreEqual(actualResult.HandType, HandType.HighCard);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Ace);
        }

        [Test]
        public void Score_WhenBothPlayersHaveAHighCardButOneHasAHigherSecondCard_ThatPlayerWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Six, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "White");
            Assert.AreEqual(actualResult.HandType, HandType.HighCard);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Nine);
        }

        [Test]
        public void Score_WhenBothPlayersHaveAHighCardButOneHasAHigherThirdCard_ThatPlayerWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Six, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "Black");
            Assert.AreEqual(actualResult.HandType, HandType.HighCard);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Seven);
        }

        [Test]
        public void Score_WhenBothPlayersHaveAHighCardButOneHasAHigherFourthCard_ThatPlayerWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.King, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.King, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "Black");
            Assert.AreEqual(actualResult.HandType, HandType.HighCard);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Seven);
        }

        [Test]
        public void Score_WhenBothPlayersHaveAHighCardButOneHasAHigherFifthCard_ThatPlayerWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "White");
            Assert.AreEqual(actualResult.HandType, HandType.HighCard);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Three);
        }

        [Test]
        public void Score_WhenOnePlayerHasAPair_ThatPlayerWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Two, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "Black");
            Assert.AreEqual(actualResult.HandType, HandType.Pair);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Jack);
        }

        [Test]
        public void Score_WhenBothPlayersHaveTheSamePairAndSameKickers_ItIsATie()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.King, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.King, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Spades}
                    }
                });

            Assert.IsNull(actualResult.Winner);
            Assert.AreEqual(actualResult.HandType, HandType.Pair);
            Assert.IsTrue(actualResult.IsTie);
            Assert.IsNull(actualResult.WinningCardValue);
        }

        [Test]
        public void Score_WhenBothPlayersHaveAPairButOneHasAHigherPair_ThatPlayerWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Six, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Six, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "White");
            Assert.AreEqual(actualResult.HandType, HandType.Pair);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Ace);
        }

        [Test]
        public void Score_WhenBothPlayersHaveTheSamePairButOneHasAHigherFirstKicker_ThatPlayerWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "Black");
            Assert.AreEqual(actualResult.HandType, HandType.Pair);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Eight);
        }

        [Test]
        public void Score_WhenBothPlayersHaveTheSamePairButOneHasAHigherSecondKicker_ThatPlayerWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "White");
            Assert.AreEqual(actualResult.HandType, HandType.Pair);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Nine);
        }

        [Test]
        public void Score_WhenBothPlayersHaveTheSamePairButOneHasAHigherThirdKicker_ThatPlayerWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "Black");
            Assert.AreEqual(actualResult.HandType, HandType.Pair);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Seven);
        }

        [Test]
        public void Score_WhenOnePlayerHasTwoPairs_ThatPlayerWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Hearts}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Two, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "Black");
            Assert.AreEqual(actualResult.HandType, HandType.TwoPairs);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Jack);
        }

        [Test]
        public void Score_WhenBothPlayersHaveTheSameTwoPairsAndSameKicker_ItIsATie()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Spades}
                    }
                });

            Assert.IsNull(actualResult.Winner);
            Assert.AreEqual(actualResult.HandType, HandType.TwoPairs);
            Assert.IsTrue(actualResult.IsTie);
            Assert.IsNull(actualResult.WinningCardValue);
        }

        [Test]
        public void Score_WhenBothPlayersHaveTwoPairsButOneHasAHigherPair_ThatPlayerWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Six, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Six, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "White");
            Assert.AreEqual(actualResult.HandType, HandType.TwoPairs);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Ace);
        }

        [Test]
        public void Score_WhenBothPlayersHaveTwoPairsAndSameHigestPairButOneHasAHigherSecondPair_ThatPlayerWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "White");
            Assert.AreEqual(actualResult.HandType, HandType.TwoPairs);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Four);
        }

        [Test]
        public void Score_WhenBothPlayersHaveTheSameTwoPairsButOneHasAHigherKicker_ThatPlayerWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "White");
            Assert.AreEqual(actualResult.HandType, HandType.TwoPairs);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Nine);
        }

        [Test]
        public void Score_WhenOnePlayerHasAThreeOfAKind_ThatPlayerWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Spades}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Two, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "Black");
            Assert.AreEqual(actualResult.HandType, HandType.ThreeOfAKind);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Jack);
        }

        [Test]
        public void Score_WhenBothPlayersHaveAThreeOfAKind_ThePlayerWithTheHigherCardWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Two, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Ten, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "Black");
            Assert.AreEqual(actualResult.HandType, HandType.ThreeOfAKind);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Jack);
        }

        [Test]
        public void Score_WhenBothPlayersHaveAThreeOfAKindButOneHasAllAces_ThatPlayerWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Six, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "White");
            Assert.AreEqual(actualResult.HandType, HandType.ThreeOfAKind);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Ace);
        }

        [Test]
        public void Score_WhenOnePlayerHasAStraight_ThatPlayerWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Two, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Six, Suit = Suit.Hearts}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Two, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "Black");
            Assert.AreEqual(actualResult.HandType, HandType.Straight);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Six);
        }

        [Test]
        public void Score_WhenBothPlayersHaveAStraight_TheOneWithTheHighestCardWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.King, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Ten, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Spades}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.King, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Ten, Suit = Suit.Clubs}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "White");
            Assert.AreEqual(actualResult.HandType, HandType.Straight);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Ace);
        }

        [Test]
        public void Score_WhenBothPlayersHaveAStraightWithTheSameCardValues_ThenItIsATie()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Ten, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Spades}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Ten, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Hearts}
                    }
                });

            Assert.IsNull(actualResult.Winner);
            Assert.AreEqual(actualResult.HandType, HandType.Straight);
            Assert.IsTrue(actualResult.IsTie);
            Assert.IsNull(actualResult.WinningCardValue);
        }

        [Test]
        public void Score_WhenOnePlayerHasAFlush_ThatPlayerWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Two, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Ten, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.King, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Two, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "Black");
            Assert.AreEqual(actualResult.HandType, HandType.Flush);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.King);
        }

        [Test]
        public void Score_WhenBothPlayersHaveAFlush_TheOneWithTheHighestCardWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Ten, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Hearts}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "White");
            Assert.AreEqual(actualResult.HandType, HandType.Flush);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Ace);
        }

        [Test]
        public void Score_WhenBothPlayersHaveAFlushWithTheSameCardValues_ThenItIsATie()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Ten, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Two, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Ten, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Diamonds}
                    }
                });

            Assert.IsNull(actualResult.Winner);
            Assert.AreEqual(actualResult.HandType, HandType.Flush);
            Assert.IsTrue(actualResult.IsTie);
            Assert.IsNull(actualResult.WinningCardValue);
        }

        [Test]
        public void Score_WhenOnePlayerHasAFullHouse_ThatPlayerWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Two, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "Black");
            Assert.AreEqual(actualResult.HandType, HandType.FullHouse);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Jack);
        }

        [Test]
        public void Score_WhenBothPlayersHaveAFullHouse_ThePlayerWithTheHigherCardWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Two, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Diamonds}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "Black");
            Assert.AreEqual(actualResult.HandType, HandType.FullHouse);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Jack);
        }

        [Test]
        public void Score_WhenBothPlayersHaveAFullHouseButOneHasAllAces_ThatPlayerWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Clubs}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "White");
            Assert.AreEqual(actualResult.HandType, HandType.FullHouse);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Ace);
        }

        [Test]
        public void Score_WhenOnePlayerHasAFourOfAKind_ThatPlayerWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Two, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "Black");
            Assert.AreEqual(actualResult.HandType, HandType.FourOfAKind);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Jack);
        }

        [Test]
        public void Score_WhenBothPlayersHaveAFourOfAKind_ThePlayerWithTheHigherCardWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Two, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "Black");
            Assert.AreEqual(actualResult.HandType, HandType.FourOfAKind);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Jack);
        }

        [Test]
        public void Score_WhenBothPlayersHaveAFourOfAKindButOneHasAllAces_ThatPlayerWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "White");
            Assert.AreEqual(actualResult.HandType, HandType.FourOfAKind);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Ace);
        }

        [Test]
        public void Score_WhenOnePlayerHasAStraightFlush_ThatPlayerWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Ten, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Two, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Spades},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "Black");
            Assert.AreEqual(actualResult.HandType, HandType.StraightFlush);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Jack);
        }

        [Test]
        public void Score_WhenOnePlayerHasASteelWheel_ThatPlayerWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Four, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Two, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "Black");
            Assert.AreEqual(actualResult.HandType, HandType.StraightFlush);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Five);
        }

        [Test]
        public void Score_WhenBothPlayersHaveASteelWheel_ThenItIsATie()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Four, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Two, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Two, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Four, Suit = Suit.Diamonds}
                    }
                });

            Assert.IsNull(actualResult.Winner);
            Assert.AreEqual(actualResult.HandType, HandType.StraightFlush);
            Assert.IsTrue(actualResult.IsTie);
            Assert.IsNull(actualResult.WinningCardValue);
        }

        [Test]
        public void Score_WhenOnePlayerHasARoyalFlush_ThatPlayerWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Ten, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.King, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Two, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Five, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Three, Suit = Suit.Spades}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "Black");
            Assert.AreEqual(actualResult.HandType, HandType.StraightFlush);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Ace);
        }

        [Test]
        public void Score_WhenBothPlayersHaveAStraightFlush_TheOneWithTheHighestCardWins()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Ten, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.King, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Ten, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.King, Suit = Suit.Hearts},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Hearts}
                    }
                });

            Assert.AreEqual(actualResult.Winner, "Black");
            Assert.AreEqual(actualResult.HandType, HandType.StraightFlush);
            Assert.IsFalse(actualResult.IsTie);
            Assert.AreEqual(actualResult.WinningCardValue, CardValue.Ace);
        }

        [Test]
        public void Score_WhenBothPlayersHaveARoyalFlush_ThenItIsATie()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Ten, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.King, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Jack, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Ten, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Queen, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.King, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Ace, Suit = Suit.Diamonds}
                    }
                });

            Assert.IsNull(actualResult.Winner);
            Assert.AreEqual(actualResult.HandType, HandType.StraightFlush);
            Assert.IsTrue(actualResult.IsTie);
            Assert.IsNull(actualResult.WinningCardValue);
        }

        [Test]
        public void Score_WhenBothPlayersHaveAStraightFlushWithEqualHighestCard_ThenItIsATie()
        {
            var pokerHandsScorer = new PokerHandsScorer();
            Result actualResult = pokerHandsScorer.Score(
                new Hand
                {
                    Name = "Black",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Six, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Ten, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Clubs},
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Clubs}
                    }
                },
                new Hand
                {
                    Name = "White",
                    Cards = new List<Card> {
                        new Card {CardValue = CardValue.Nine, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Ten, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Eight, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Six, Suit = Suit.Diamonds},
                        new Card {CardValue = CardValue.Seven, Suit = Suit.Diamonds}
                    }
                });

            Assert.IsNull(actualResult.Winner);
            Assert.AreEqual(actualResult.HandType, HandType.StraightFlush);
            Assert.IsTrue(actualResult.IsTie);
            Assert.IsNull(actualResult.WinningCardValue);
        }
    }
}