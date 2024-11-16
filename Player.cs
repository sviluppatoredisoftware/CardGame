using System;

namespace CardGame
{
    internal class Player(string name)
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
        public void PrintHand()
        {
            Console.WriteLine($"{Name} has the following cards:");
            foreach (Card card in Hand)
            {
                Console.WriteLine($"{card.Name} of {card.Suit}");
            }
        }
    }
}