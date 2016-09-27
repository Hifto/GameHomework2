using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHomework2
{
    abstract class Hand
    {
        public List<Card> hand = new List<Card>();

        /// <summary>
        /// Adds a card to this hand
        /// </summary>
        /// <param name="card"></param>
        public void AddCard(Card card)
        {
            hand.Add(card);
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
            foreach (Card element in hand)
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
            hand.Clear();
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

            foreach (Card element in hand)
            {
                if(card.CompareTo(element) == 0)
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
            return hand[index];
        }

        /// <summary>
        /// Returns the number of cards in the hand
        /// </summary>
        /// <returns></returns>
        public int GetNumberOfCards()
        {
            return hand.Count;
        }

        /// <summary>
        /// Returns true if the hand is empty, false otherwise
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            if (hand.Count == 0)
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

            for (int count = 0; count < hand.Count; count++)
            {
                if (card.CompareTo(hand[count]) == 0)
                {
                    removedCard = hand[count];
                    hand.Remove(hand[count]);
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

            removedCard = hand[index];
            hand.Remove(hand[index]);

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
            string DescribeHand = "In this hand there is: " + "\n";

            foreach (Card element in hand)
            {
                DescribeHand += (element.GetRank()) + " of " + (element.GetSuit() + "\n");
            }

            return DescribeHand;
        }
    }
}
