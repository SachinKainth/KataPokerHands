using System.Collections.Generic;

namespace PokerHands
{
    public class Hand
    {
        public string Name { get; set; }
        public IList<Card> Cards { get; set; }
    }
}