using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHomework2
{
    abstract class Hand
    {
        /// <summary>
        /// Adds a card to this hand
        /// </summary>
        /// <param name="card"></param>
        public void AddCard(Card card)
        {

        }

        /// <summary>
        /// Compares two hands
        /// </summary>
        /// <param name="OtherHandObject"></param>
        /// <returns></returns>
        public abstract int CompareTo(Hand OtherHandObject);

        /// <summary>
        /// Returns true if the card is in this hand, false otherwise
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public bool ContainsCard(Card card)
        {
            return true;
        }

        /// <summary>
        /// Throws away all cards in the hand, leaving an empty hand
        /// </summary>
        public void DiscardHand()
        {

        }

        /// <summary>
        /// Searches the hand for the first occurence of the specified
        /// card and returns the index
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public int FindCard(Card card)
        {
            return 0;
        }

        /// <summary>
        /// Obtains the card stored at the specified
        /// location in the hand
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Card GetCardAtIndex(int index)
        {
            return null;
        }

        /// <summary>
        /// Returns the number of cards in the hand
        /// </summary>
        /// <returns></returns>
        public int GetNumberOfCards()
        {
            return 0;
        }

        /// <summary>
        /// Returns true if the hand is empty, false otherwise
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return true;
        }

        /// <summary>
        /// Removes the first occurance of the specified card
        /// from this hand
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public Card RemoveCard(Card card)
        {
            return null;
        }

        /// <summary>
        /// Removes card at the specified index position 
        /// from this hand
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Card RemoveCard(int index)
        {
            return null;
        }

        /// <summary>
        /// Evaluates the hand, returns an integer corresponding to the
        /// rating of the hand
        /// </summary>
        /// <returns></returns>
        public abstract int EvaluateHand();

        /// <summary>
        /// A description of this hand, which includes all cards in the hand
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            return "";
        }
    }
}
