using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHomework2
{
    class CardCountGame
    {
        public static string PlayGame()
        {
            CardCountHand handOne = new CardCountHand();
            CardCountHand handTwo = new CardCountHand();

            Deck deck = new Deck();

            //Creates a deck of 52 cards
            for (int n = 0; n < Suit.VALUES.Count; n++)
            {
                for (int o = 0; o < Rank.VALUES.Count; o++)
                {
                    Card card = new Card(Suit.VALUES[n], Rank.VALUES[o]);
                    deck.AddCard(card);
                }
            }

            deck.Shuffle();

            //Deals 8 cards to each hand
            for (int n = 0; n < 8; n++)
            {
                handOne.AddCard(deck.DealOne());
                handTwo.AddCard(deck.DealOne());
            }

            //Welcome message
            Console.WriteLine("Welcome to Card Count!\n");

            //Displays all of the cards in each hand
            Console.WriteLine("Hand 1: " + handOne.ToString());
            Console.WriteLine("Hand 2: " + handTwo.ToString());

            //Displays the score of each hand
            Console.WriteLine("Hand 1 Score: " + handOne.EvaluateHand());
            Console.WriteLine("Hand 2 Score: " + handTwo.EvaluateHand());

            //Displays the cards remaining in the deck
            Console.WriteLine("Cards remaining in deck: " + deck.GetCardsRemaining());

            //Compare the two hands to see who wins
            if (handOne.CompareTo(handTwo) == 0)
            {
                Console.WriteLine("It's a tie!");
                return "It's a tie!";
            }
            else if (handOne.CompareTo(handTwo) == -1)
            {
                Console.WriteLine("Hand 2 Wins!");
                return "Hand 2 Wins!";
            }
            else if (handOne.CompareTo(handTwo) == 1)
            {
                Console.WriteLine("Hand 1 Wins!");
                return "Hand 1 Wins!";
            }
            else
            {
                return "";
            }
        }
    }
}
