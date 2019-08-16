using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighPlusLow
{
    class ProcessRound : Card
    {
        public void Round(int currentCard, int guess)
        {
            // int cardValue = currentCard;
            Random random = new Random();
            int randomCard = random.Next(2, 14);

            do
            {
                Console.WriteLine("High or Low? ");
                string guessInput = Console.ReadLine();
                int guessValue = Convert.ToInt32(guessInput);
            }
            while (guess < 0 || guess > 1);

            Console.WriteLine("Current card: " + currentCard);
            Console.WriteLine("Drawn card: " + randomCard);

            if ((guess == 0 && randomCard > currentCard) || (guess == 1 && randomCard < currentCard))
            {
                Console.WriteLine("Lucky guess! YOU WIN!:)");
            }
            else if ((guess == 0 && randomCard < currentCard) || (guess == 1 && randomCard > currentCard))
            {
                Console.WriteLine("Wrong guess! YOU LOSE!:(");
            }            
            else
            {
                Console.WriteLine("DRAW!");
            }

            

            Console.ReadLine();
        }

        public int CompareCards(Card CardInHand, Card DrawnCard)
        {

        }
    }
}
