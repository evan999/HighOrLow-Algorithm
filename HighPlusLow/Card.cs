using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighPlusLow
{
    class Card
    {
        private string suit;
        private int cardValue;

        public Card(string suit, int cardValue)
        {
            this.suit = suit;
            this.cardValue = cardValue;
        }

        public Card DrawCard()
        {
            Card drawnCard = new Card();
            drawnCard.GenerateCardValue();
            return drawnCard;
        }

        private int GenerateCardValue()
        {
            Random randomValue = new Random();
            int cardValue = randomValue.Next(2, 14);
            return cardValue;
        }
        
        /*
        public Card SelectCard()
        {
            string cardType = "Suit";
            return cardType;
        }
        */
    }
}

