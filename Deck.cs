namespace CardGame
{
    internal class Deck
    {
        public List<Card> Active { get; private set; } = new List<Card>();
        public List<Card> Dead { get; private set; } = new List<Card>();

        public Deck()
        {
            for (int i = 6; i <= 14; i++)
            {
                Active.Add(new Card(i, "Spades"));
                Active.Add(new Card(i, "Hearts"));
                Active.Add(new Card(i, "Clubs"));
                Active.Add(new Card(i, "Diamonds"));
            }
            PrintActive();
            Shuffle();
            PrintActive();
        }
        public void Shuffle()
        {
            Random random = new Random();
            for (int i = Active.Count - 1; i >= 0; i--)
            {
                int j = random.Next(i + 1);
                var tmp = Active[i];
                Active[i] = Active[j];
                Active[j] = tmp;
            }
        }
        public void PrintActive()
        {
            foreach (Card card in Active)
            {
                Console.WriteLine($"{card.Name} of {card.Suit}");
            }
        }
        public void PrintInactive()
        {
            foreach (Card card in Dead)
            {
                Console.WriteLine($"{card.Name} of {card.Suit}");
            }
        }
    }
}
