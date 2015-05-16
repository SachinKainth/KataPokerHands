namespace PokerHands
{
    public class Result
    {
        public string Winner { get; set; }
        public bool IsTie { get; set; }
        public HandType HandType { get; set; }
        public CardValue? WinningCardValue { get; set; }
    }
}