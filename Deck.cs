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
            Shuffle();
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
        public void SetTrump()
        {
            var trump = Active[Active.Count - 1].Suit;
            Active.ForEach(x => x.SetTrump(trump));
        }
        public void DealCards(List<Player> players, int cardsPer)
        {
            for (int i = 0; i < cardsPer; i++)
            {
                foreach (var player in players)
                {
                    if (Active.Count > 0)
                    {
                        Card card = Active[0];
                        Active.RemoveAt(0);
                        player.GiveCard(card);
                    }
                }
            }
        }
        public void PrintActive()
        {
            Console.WriteLine("Active Cards:");
            foreach (Card card in Active)
            {
                Console.WriteLine($"{card.Name} of {card.Suit} {(card.IsTrump?"Trump":"")}");
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
