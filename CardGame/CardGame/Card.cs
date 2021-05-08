using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Card
    {
        public string CardType { get; set; }
        public CardSuit CardSuit { get; set; }

        public Card(string CardType, CardSuit CardSuit)
        {
            this.CardType = CardType;
            this.CardSuit = CardSuit;
        }
    }
}
