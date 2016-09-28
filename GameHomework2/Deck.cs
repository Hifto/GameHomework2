using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHomework2
{
    class Deck
    {
        public List<Card> deckList = new List<Card>();
        public List<Card> perfectDeck = new List<Card>();

        private static readonly Random rng = new Random();

        /// <summary>
        /// Creates an empty deck of cards
        /// </summary>
        public Deck()
        {

        }

        /// <summary>
        /// Adds a card to the deck
        /// </summary>
        /// <param name="card"></param>
        public void AddCard(Card card)
        {
            deckList.Add(card);
            perfectDeck.Add(card);
        }

        /// <summary>
        /// Deal one card from the deck
        /// </summary>
        /// <returns></returns>
        public Card DealOne()
        {
            int rand = rng.Next(deckList.Count);
            Card dealt = deckList[rand];

            deckList.Remove(deckList[rand]);

            return dealt;
        }

        /// <summary>
        /// Returns the number of cards remaining in the current deck
        /// </summary>
        /// <returns></returns>
        public int GetCardsRemaining()
        {
            return deckList.Count;
        }

        /// <summary>
        /// Returns the size of a full deck of cards
        /// </summary>
        /// <returns></returns>
        public int GetDeckSize()
        {
            return perfectDeck.Count();
        }

        /// <summary>
        /// Returns true if deck is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            if (deckList.Count == 0)
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
        public void Shuffle()
        {
            int shuffle = deckList.Count;

            while (shuffle > 1)
            {
                int replace = (rng.Next(0, shuffle) % shuffle);
                shuffle--;
                Card held = deckList[replace];
                deckList[replace] = deckList[shuffle];
                deckList[shuffle] = held;
            }

        }

        /// <summary>
        /// Resets the deck back to a full deck by replacing any cards
        /// that were dealt out
        /// </summary>
        public void RestoreDeck()
        {
            deckList.AddRange(perfectDeck);
        }
    }
}
