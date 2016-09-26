using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHomework2
{
    class Deck
    {
        static List<Card> cards;
        private static readonly Random rng = new Random();

        /// <summary>
        /// Creates an empty deck of cards
        /// </summary>
        Deck()
        {

        }

        /// <summary>
        /// Adds a card to the deck
        /// </summary>
        /// <param name="card"></param>
        void AddCard(Card card)
        {
            cards.Add(card);
        }

        /// <summary>
        /// Deal one card from the deck
        /// </summary>
        /// <returns></returns>
        Card DealOne()
        {
            return cards[rng.Next(cards.Count)];
        }

        /// <summary>
        /// Returns the number of cards remaining in the current deck
        /// </summary>
        /// <returns></returns>
        int GetCardsRemaining()
        {
            return cards.Count;
        }

        /// <summary>
        /// Returns the size of a full deck of cards
        /// </summary>
        /// <returns></returns>
        int GetDeckSize()
        {
            return cards.Capacity;
        }

        /// <summary>
        /// Returns true if deck is empty
        /// </summary>
        /// <returns></returns>
        bool IsEmpty()
        {
            if (cards.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Shuffles the deck of cards that are present in the deck
        /// </summary>
        void Shuffle()
        {
            int shuffle = cards.Count;

            while (shuffle > 1)
            {
                int replace = (rng.Next(0, shuffle) % shuffle);
                shuffle--;
                Card held = cards[replace];
                cards[replace] = cards[shuffle];
                cards[shuffle] = held;
            }

        }

        /// <summary>
        /// Resets the deck back to a full deck by replacing any cards
        /// that were dealt out
        /// </summary>
        void RestoreDeck()
        {

        }
    }
}
