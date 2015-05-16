using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerHands
{
    public class PokerHandsScorer
    {
        public Result Score(Hand player1Hand, Hand player2Hand)
        {
            var straightFlushResult = StraightFlushResult(player1Hand, player2Hand);
            if (straightFlushResult != null)
            {
                return straightFlushResult;
            }

            var fourOfAKindResult = FourOfAKindResult(player1Hand, player2Hand);
            if (fourOfAKindResult != null)
            {
                return fourOfAKindResult;
            }

            var fullHouseResult = FullHouseResult(player1Hand, player2Hand);
            if (fullHouseResult != null)
            {
                return fullHouseResult;
            }

            var flushResult = FlushResult(player1Hand, player2Hand);
            if (flushResult != null)
            {
                return flushResult;
            }

            var straightResult = StraightResult(player1Hand, player2Hand);
            if (straightResult != null)
            {
                return straightResult;
            }

            var threeOfAKindResult = ThreeOfAKindResult(player1Hand, player2Hand);
            if (threeOfAKindResult != null)
            {
                return threeOfAKindResult;
            }

            var twoPairsResult = TwoPairsResult(player1Hand, player2Hand);
            if (twoPairsResult != null)
            {
                return twoPairsResult;
            }

            var pairResult = PairResult(player1Hand, player2Hand);
            if (pairResult != null)
            {
                return pairResult;
            }

            var highCardResult = HighCardResult(player1Hand, player2Hand);
            return highCardResult;
        }

        private Result HighCardResult(Hand player1Hand, Hand player2Hand)
        {
            var highCardPlayer1 = CheckForHighCard(player1Hand);
            var highCardPlayer2 = CheckForHighCard(player2Hand);

            if (highCardPlayer1.result == true && highCardPlayer2.result == false)
            {
                return new Result
                {
                    HandType = HandType.HighCard,
                    IsTie = false,
                    Winner = player1Hand.Name,
                    WinningCardValue = (CardValue)highCardPlayer1.highCards[0]
                };
            }
            if (highCardPlayer1.result == false && highCardPlayer2.result == true)
            {
                return new Result
                {
                    HandType = HandType.HighCard,
                    IsTie = false,
                    Winner = player2Hand.Name,
                    WinningCardValue = (CardValue)highCardPlayer2.highCards[0]
                };
            }
            if (highCardPlayer1.result == true && highCardPlayer2.result == true)
            {
                var isTie = IsTie(highCardPlayer1, highCardPlayer2);

                var result = GetWinnerAndWinningCardInWinningGame(player1Hand, player2Hand, isTie, highCardPlayer1, highCardPlayer2);
                return new Result
                {
                    HandType = HandType.HighCard,
                    IsTie = isTie,
                    Winner = result.winner,
                    WinningCardValue = result.winningCardValue
                };
            }

            return null;
        }

        private Result PairResult(Hand player1Hand, Hand player2Hand)
        {
            var pairPlayer1 = CheckForPair(player1Hand);
            var pairPlayer2 = CheckForPair(player2Hand);

            if (pairPlayer1.result == true && pairPlayer2.result == false)
            {
                return new Result
                {
                    HandType = HandType.Pair,
                    IsTie = false,
                    Winner = player1Hand.Name,
                    WinningCardValue = (CardValue)pairPlayer1.highCards[0]
                };
            }
            if (pairPlayer1.result == false && pairPlayer2.result == true)
            {
                return new Result
                {
                    HandType = HandType.Pair,
                    IsTie = false,
                    Winner = player2Hand.Name,
                    WinningCardValue = (CardValue)pairPlayer2.highCards[0]
                };
            }
            if (pairPlayer1.result == true && pairPlayer2.result == true)
            {
                var isTie = IsTie(pairPlayer1, pairPlayer2);
                
                var result = GetWinnerAndWinningCardInWinningGame(player1Hand, player2Hand, isTie, pairPlayer1, pairPlayer2);
                return new Result
                {
                    HandType = HandType.Pair,
                    IsTie = isTie,
                    Winner = result.winner,
                    WinningCardValue = result.winningCardValue
                };
            }

            return null;
        }

        private Result TwoPairsResult(Hand player1Hand, Hand player2Hand)
        {
            var twoPairsPlayer1 = CheckForTwoPairs(player1Hand);
            var twoPairsPlayer2 = CheckForTwoPairs(player2Hand);

            if (twoPairsPlayer1.result == true && twoPairsPlayer2.result == false)
            {
                return new Result
                {
                    HandType = HandType.TwoPairs,
                    IsTie = false,
                    Winner = player1Hand.Name,
                    WinningCardValue = (CardValue)twoPairsPlayer1.highCards[0]
                };
            }
            if (twoPairsPlayer1.result == false && twoPairsPlayer2.result == true)
            {
                return new Result
                {
                    HandType = HandType.TwoPairs,
                    IsTie = false,
                    Winner = player2Hand.Name,
                    WinningCardValue = (CardValue)twoPairsPlayer2.highCards[0]
                };
            }
            if (twoPairsPlayer1.result == true && twoPairsPlayer2.result == true)
            {
                var isTie = IsTie(twoPairsPlayer1, twoPairsPlayer2);
                
                var result = GetWinnerAndWinningCardInWinningGame(player1Hand, player2Hand, isTie, twoPairsPlayer1, twoPairsPlayer2);
                return new Result
                {
                    HandType = HandType.TwoPairs,
                    IsTie = isTie,
                    Winner = result.winner,
                    WinningCardValue = result.winningCardValue
                };
            }

            return null;
        }

        private Result ThreeOfAKindResult(Hand player1Hand, Hand player2Hand)
        {
            var threeOfAKindPlayer1 = CheckForNOfAKind(player1Hand, 3, 3);
            var threeOfAKindPlayer2 = CheckForNOfAKind(player2Hand, 3, 3);

            return GetResultWhereTiesAreDecidedBySingleHighestCard(
                player1Hand, player2Hand, threeOfAKindPlayer1, threeOfAKindPlayer2, HandType.ThreeOfAKind);
        }

        private Result StraightResult(Hand player1Hand, Hand player2Hand)
        {
            var straightPlayer1 = CheckForStraight(player1Hand);
            var straightPlayer2 = CheckForStraight(player2Hand);

            return GetResultWhereTiesAreResolvedByComparingNextHighestCards(
                player1Hand, player2Hand, straightPlayer1, straightPlayer2, HandType.Straight);
        }

        private Result FlushResult(Hand player1Hand, Hand player2Hand)
        {
            var flushPlayer1 = CheckForFlush(player1Hand);
            var flushPlayer2 = CheckForFlush(player2Hand);

            return GetResultWhereTiesAreResolvedByComparingNextHighestCards(
                player1Hand, player2Hand, flushPlayer1, flushPlayer2, HandType.Flush);
        }

        private Result FullHouseResult(Hand player1Hand, Hand player2Hand)
        {
            var fullHousePlayer1 = CheckForFullHouse(player1Hand);
            var fullHousePlayer2 = CheckForFullHouse(player2Hand);

            return GetResultWhereTiesAreDecidedBySingleHighestCard(
                player1Hand, player2Hand, fullHousePlayer1, fullHousePlayer2, HandType.FullHouse);
        }

        private Result FourOfAKindResult(Hand player1Hand, Hand player2Hand)
        {
            var fourOfAKindPlayer1 = CheckForNOfAKind(player1Hand, 2, 4);
            var fourOfAKindPlayer2 = CheckForNOfAKind(player2Hand, 2, 4);

            return GetResultWhereTiesAreDecidedBySingleHighestCard(
                player1Hand, player2Hand, fourOfAKindPlayer1, fourOfAKindPlayer2, HandType.FourOfAKind);
        }

        private Result StraightFlushResult(Hand player1Hand, Hand player2Hand)
        {
            var straightFlushPlayer1 = CheckForStraightFlush(player1Hand);
            var straightFlushPlayer2 = CheckForStraightFlush(player2Hand);

            if (straightFlushPlayer1.result == true && straightFlushPlayer2.result == false)
            {
                return new Result
                {
                    HandType = HandType.StraightFlush,
                    IsTie = false,
                    Winner = player1Hand.Name,
                    WinningCardValue = straightFlushPlayer1.highCard
                };
            }
            if (straightFlushPlayer1.result == false && straightFlushPlayer2.result == true)
            {
                return new Result
                {
                    HandType = HandType.StraightFlush,
                    IsTie = false,
                    Winner = player2Hand.Name,
                    WinningCardValue = straightFlushPlayer2.highCard
                };
            }
            if (straightFlushPlayer1.result == true && straightFlushPlayer2.result == true)
            {
                bool isTie = straightFlushPlayer1.highCard == straightFlushPlayer2.highCard;
                return new Result
                {
                    HandType = HandType.StraightFlush,
                    IsTie = isTie,
                    Winner =
                        isTie
                            ? null
                            : straightFlushPlayer1.highCard > straightFlushPlayer2.highCard
                                ? player1Hand.Name
                                : player2Hand.Name,
                    WinningCardValue = isTie
                        ? null
                        : (CardValue?)Math.Max((int)straightFlushPlayer1.highCard, (int)straightFlushPlayer2.highCard)
                };
            }

            return null;
        }

        private Result GetResultWhereTiesAreResolvedByComparingNextHighestCards(
            Hand player1Hand, Hand player2Hand,
            dynamic player1Result, dynamic player2Result, HandType handType)
        {
            if (player1Result.result == true && player2Result.result == false)
            {
                return new Result
                {
                    HandType = handType,
                    IsTie = false,
                    Winner = player1Hand.Name,
                    WinningCardValue = (CardValue)player1Result.highCards[player1Result.highCards.Count - 1]
                };
            }
            if (player1Result.result == false && player2Result.result == true)
            {
                return new Result
                {
                    HandType = handType,
                    IsTie = false,
                    Winner = player2Hand.Name,
                    WinningCardValue = (CardValue)player2Result.highCards[player2Result.highCards.Count - 1]
                };
            }
            if (player1Result.result == true && player2Result.result == true)
            {
                string winner = null;
                bool isTie = true;
                CardValue? winningCardValue = null;

                for (var i = player1Result.highCards.Count - 1; i >= 0; i--)
                {
                    if (player1Result.highCards[i] > player2Result.highCards[i])
                    {
                        winner = player1Hand.Name;
                        isTie = false;
                        winningCardValue = (CardValue)player1Result.highCards[i];
                        break;
                    }
                    if (player1Result.highCards[i] < player2Result.highCards[i])
                    {
                        winner = player2Hand.Name;
                        isTie = false;
                        winningCardValue = (CardValue)player2Result.highCards[i];
                        break;
                    }
                }

                return new Result
                {
                    HandType = handType,
                    IsTie = isTie,
                    Winner = isTie ? null : winner,
                    WinningCardValue = isTie ? null : winningCardValue
                };
            }

            return null;
        }

        private Result GetResultWhereTiesAreDecidedBySingleHighestCard(
            Hand player1Hand, Hand player2Hand,
            dynamic player1Result, dynamic player2Result, HandType handType)
        {
            if (player1Result.result == true && player2Result.result == false)
            {
                return new Result
                {
                    HandType = handType,
                    IsTie = false,
                    Winner = player1Hand.Name,
                    WinningCardValue = player1Result.highCard
                };
            }
            if (player1Result.result == false && player2Result.result == true)
            {
                return new Result
                {
                    HandType = handType,
                    IsTie = false,
                    Winner = player2Hand.Name,
                    WinningCardValue = player2Result.highCard
                };
            }
            if (player1Result.result == true && player2Result.result == true)
            {
                return new Result
                {
                    HandType = handType,
                    IsTie = false,
                    Winner =
                        player1Result.highCard > player2Result.highCard
                            ? player1Hand.Name
                            : player2Hand.Name,
                    WinningCardValue =
                        (CardValue)Math.Max((int)player1Result.highCard, (int)player2Result.highCard)
                };
            }

            return null;
        }

        private dynamic GetWinnerAndWinningCardInWinningGame(
            Hand player1Hand, Hand player2Hand, bool isTie,
            dynamic highCardPlayer1, dynamic highCardPlayer2)
        {
            string winner = null;
            CardValue? winningCardValue = null;
            if (!isTie)
            {
                for (var i = 0; i < highCardPlayer1.highCards.Count; i++)
                {
                    var player1Card = highCardPlayer1.highCards[i];
                    var player2Card = highCardPlayer2.highCards[i];
                    if (player1Card > player2Card)
                    {
                        winner = player1Hand.Name;
                        winningCardValue = (CardValue) highCardPlayer1.highCards[i];
                        break;
                    }
                    if (player2Card > player1Card)
                    {
                        winner = player2Hand.Name;
                        winningCardValue = (CardValue) highCardPlayer2.highCards[i];
                        break;
                    }
                }
            }

            return new
            {
                winner,
                winningCardValue
            };
        }

        private dynamic CheckForHighCard(Hand playerHand)
        {
            var cardValues = playerHand.Cards
                .Select(card => (int)card.CardValue)
                .OrderByDescending(c => c)
                .ToList();
            
            return new
            {
                result = true,
                highCards = cardValues
            };
        }

        private dynamic CheckForPair(Hand playerHand)
        {
            var groups = playerHand.Cards.GroupBy(c => c.CardValue).ToList();
            var pairs = groups.Where(g => g.Count() == 2).ToList();
            var kickers = groups.Where(g => g.Count() == 1).ToList();

            if (groups.Count() == 4 && pairs.Count() == 1)
            {
                var min = (int)kickers.Min(g => g.Key);
                var max = (int)kickers.Max(g => g.Key);

                return new
                {
                    result = true,
                    highCards = new List<int>
                        {
                            (int)pairs[0].Key,
                            max,
                            (int)kickers.Single(g => (int)g.Key != min && (int)g.Key != max).Key,
                            min
                        }
                };
            }

            return new { result = false };
        }

        private dynamic CheckForTwoPairs(Hand playerHand)
        {
            var groups = playerHand.Cards.GroupBy(c => c.CardValue).ToList();
            var pairs = groups.Where(g => g.Count() == 2).ToList();

            if (groups.Count() == 3 && pairs.Count() == 2)
            {
                return new
                {
                    result = true,
                    highCards = new List<int>
                        {
                            (int)pairs.Max(p => p.Key),
                            (int)pairs.Min(p => p.Key),
                            (int)groups.Single(g => g.Count() == 1).Key
                        }
                };
            }   

            return new { result = false };
        }

        private dynamic CheckForNOfAKind(Hand playerHand, int groupCountForNOfAKind, int N)
        {
            var groups = playerHand.Cards.GroupBy(c => c.CardValue).ToList();

            var nOfAKindGroup = groups.SingleOrDefault(g => g.Count() == N);

            if (groups.Count() == groupCountForNOfAKind && nOfAKindGroup != null)
            {
                return new
                {
                    result = true,
                    highCard = nOfAKindGroup.Key
                };
            }

            return new { result = false };
        }

        private dynamic CheckForStraight(Hand playerHand)
        {
            var cardValues = playerHand.Cards.Select(card => (int)card.CardValue).ToList();
            cardValues.Sort();

            var handCount = cardValues.Count;

            var areConsequtive = true;
            for (var i = 0; i < handCount - 1; i++)
            {
                var pairIsConsequtive = cardValues[i] == cardValues[i + 1] - 1;
                if (!pairIsConsequtive)
                {
                    areConsequtive = false;
                }
            }
        
            if (!areConsequtive)
            {
                return new { result = false };
            }

            return new
            {
                result = true,
                highCards = cardValues
            };
        }

        private dynamic CheckForFlush(Hand playerHand)
        {
            var suit = playerHand.Cards.First().Suit;
            bool allSuitsTheSame = playerHand.Cards.All(card => card.Suit == suit);

            if (!allSuitsTheSame)
            {
                return new { result = false };
            }

            var cardValues = playerHand.Cards.Select(card => (int)card.CardValue).ToList();
            cardValues.Sort();
            
            return new
            {
                result = true,
                highCards = cardValues
            };
        }

        private dynamic CheckForFullHouse(Hand playerHand)
        {
            const int groupCountForFullHouse = 2;
            const int three = 3;
            var groups = playerHand.Cards.GroupBy(c => c.CardValue).ToList();

            if (groups.Count() == groupCountForFullHouse)
            {
                return new
                {
                    result = true,
                    highCard = groups.Single(g => g.Count() == three).Key
                };
            }

            return new { result = false };
        }

        private dynamic CheckForStraightFlush(Hand playerHand)
        {
            var suit = playerHand.Cards.First().Suit;
            bool allSuitsTheSame = playerHand.Cards.All(card => card.Suit == suit);
            
            if (!allSuitsTheSame)
            {
                return new {result = false};
            }

            var cardValues = playerHand.Cards.Select(card => (int) card.CardValue).ToList();
            cardValues.Sort();

            var handCount = cardValues.Count;

            var areConsequtive = true;
            for (var i = 0; i < handCount - 1; i++)
            {
                var pairIsConsequtive = cardValues[i] == cardValues[i + 1] - 1;
                if (pairIsConsequtive) continue;
                areConsequtive = i == handCount - 2 &&
                                 cardValues[i] == (int) CardValue.Five &&
                                 cardValues[i + 1] == (int) CardValue.Ace;
            }

            if (!areConsequtive)
            {
                return new { result = false };
            }

            return new
            {
                result = true, 
                highCard = (
                    cardValues[handCount-1] == (int) CardValue.Ace &&
                    cardValues[0] == (int) CardValue.Two) ? CardValue.Five : (CardValue)cardValues[handCount-1]
            };
        }

        private bool IsTie(dynamic highCardPlayer1, dynamic highCardPlayer2)
        {
            bool isTie = true;
            for (var i = 0; i < highCardPlayer1.highCards.Count; i++)
            {
                if (highCardPlayer1.highCards[i] != highCardPlayer2.highCards[i])
                {
                    isTie = false;
                    break;
                }
            }
            return isTie;
        }
    }
}