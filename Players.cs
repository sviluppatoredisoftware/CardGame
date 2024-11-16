namespace CardGame
{
    internal class Players(string name)
    {
        public string Name { get; private set; } = name;
        public List<Card> Hand { get; private set; } = new List<Card>();

        public void GiveCard(Card card)
        {
            Hand.Add(card);
        }
        public void RemoveAllCards()
        {
            Hand.Clear();
        }
    }
}