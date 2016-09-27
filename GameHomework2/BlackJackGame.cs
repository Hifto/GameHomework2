using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHomework2
{
    class BlackJackGame
    {
        public static string PlayGame()
        {
            BlackJackHand userHand = new BlackJackHand();
            BlackJackHand compHand = new BlackJackHand();

            Deck deck = new Deck();

            //Creates a six sets of a standard 52 card deck
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


        }
    }
}
