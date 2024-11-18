using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGame
{
    public class Game
    {
        public List<Player> ActivePlayers { get; private set; }
        public Game(List<Player> activePlayers) 
        {
            ActivePlayers = activePlayers;
        }
    }
}