using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHomework2
{
    class BlackJackGame
    {
        private static readonly Random rng = new Random();

        public static string PlayGame()
        {
            BlackJackHand userHand = new BlackJackHand();
            BlackJackHand compHand = new BlackJackHand();

            Deck deck = new Deck();

            //Creates six sets of a standard 52 card deck
            for (int n = 0; n < 6; n++)
            {
                for (int o = 0; o < Suit.VALUES.Count; o++)
                {
                    for (int p = 0; p < Rank.VALUES.Count; p++)
                    {
                        Card card = new Card(Suit.VALUES[o], Rank.VALUES[p]);
                        deck.AddCard(card);
                    }
                }
            }

            //Welcome message
            Console.WriteLine("Welcome to BlackJack!\n");

            //Adds starting cards to hand
            userHand.AddCard(deck.DealOne());
            Console.WriteLine("You have been dealt the: " + userHand.GetCardAtIndex(0).GetRank().GetName() + userHand.GetCardAtIndex(0).GetSuit().GetName() + ".\n");
            userHand.AddCard(deck.DealOne());
            Console.WriteLine("You have been dealt the: " + userHand.GetCardAtIndex(1).GetRank().GetName() + userHand.GetCardAtIndex(1).GetSuit().GetName() + ".\n");

            Console.WriteLine("Hit or Stand (H/S)?\n");

            string answer = Console.ReadLine().ToUpper();

            if (answer.Equals("H"))
            {
                int indexValue = 0;

                for (int n = 0; n < deck.deckList.Count; n++)
                {
                    userHand.AddCard(deck.DealOne());
                    Console.WriteLine("You have been dealt the: " + userHand.GetCardAtIndex(indexValue).GetRank().GetName() + userHand.GetCardAtIndex(indexValue).GetSuit().GetName() + ".\n");
                    indexValue++;

                    Console.WriteLine("Hit or Stand (H/S)?\n");
                }

            }
        }
    }
}
