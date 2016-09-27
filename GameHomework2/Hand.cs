using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHomework2
{
    abstract class Hand
    {
        public List<Card> listOfCards = new List<Card>();

        /// <summary>
        /// Adds a card to this hand
        /// </summary>
        /// <param name="card"></param>
        public void AddCard(Card card)
        {
            listOfCards.Add(card);
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
            foreach (Card element in listOfCards)
            {
                if (card.CompareTo(element) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        /// <summary>
        /// Throws away all cards in the hand, leaving an empty hand
        /// </summary>
        public void DiscardHand()
        {
            listOfCards.Clear();
        }

        /// <summary>
        /// Searches the hand for the first occurence of the specified
        /// card and returns the index
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public int FindCard(Card card)
        {
            int count = 0;

            foreach (Card element in listOfCards)
            {
                if (card.CompareTo(element) == 0)
                {
                    return count;
                }
                count++;
            }
            return count;
        }

        /// <summary>
        /// Obtains the card stored at the specified
        /// location in the hand
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Card GetCardAtIndex(int index)
        {
            return listOfCards[index];
        }

        /// <summary>
        /// Returns the number of cards in the hand
        /// </summary>
        /// <returns></returns>
        public int GetNumberOfCards()
        {
            return listOfCards.Count;
        }

        /// <summary>
        /// Returns true if the hand is empty, false otherwise
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            if (listOfCards.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Removes the first occurance of the specified card
        /// from this hand
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public Card RemoveCard(Card card)
        {
            Card removedCard;

            for (int count = 0; count < listOfCards.Count; count++)
            {
                if (card.CompareTo(listOfCards[count]) == 0)
                {
                    removedCard = listOfCards[count];
                    listOfCards.Remove(listOfCards[count]);
                    return removedCard;
                }
            }
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
            Card removedCard;

            removedCard = listOfCards[index];
            listOfCards.Remove(listOfCards[index]);

            return removedCard;
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
        public override string ToString()
        {
            string DescribeHand = "";

            foreach (Card element in listOfCards)
            {
                DescribeHand += (element.GetRank()) + (element.GetSuit() + " ");
            }

            return DescribeHand;
        }
    }
}
