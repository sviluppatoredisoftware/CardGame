namespace CardGame
{
    internal class Program
    {
        static int Main()
        {

            var pat = new Player("Patrick");
            List<Player> list = new List<Player>() { pat };
            Deck deck = new Deck();

            deck.DealCards(list, 18);
            pat.PrintHand();
            deck.PrintActive();
            return 0;
        }

    }
}