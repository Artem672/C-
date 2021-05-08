using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Player
    {
        public List<Card> AvailableCards = new();

        public void PrintPlayerDeck()
        {
            foreach(var item in AvailableCards)
            {
                Console.WriteLine($"{item.CardType} {item.CardSuit}");
            }
        }
    }
}
