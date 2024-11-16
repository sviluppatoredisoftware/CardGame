namespace CardGame
{
    internal class Card
    {
        private static readonly string[] _names = { "", "One","Two", "Three", "Four", "Five", "Six", "Seven", "Eight",
            "Nine", "Ten", "Jack", "Queen", "King", "Ace"};
        public int Value { get; private set; }
        public string Suit { get; private set; }
        public bool IsTrump { get; private set; }
        public string Name { get; private set; }
        public Card(int value, string suit)
        {
            Value = value;
            Suit = suit;
            IsTrump = false;
            Name = _names[value];
        }
        public void SetTrump(bool setTrump)
        {
            IsTrump = setTrump;
        }
    }
}
