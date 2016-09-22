using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHomework2
{
    class Card
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="suit"></param>
        /// <param name="rank"></param>
        public Card(Suit suit, Rank rank)
        {

        }

        /// <summary>
        ///  Returns a 0 if the cards are the same, -1 if this card would be sorted lower than the other card, 
        ///  1 if this object would be sorted higher than the other card
        /// </summary>
        /// <param name="OtherCardObject"></param>
        /// <returns></returns>
        int CompareTo(Card OtherCardObject)
        {
            return 0;
        }

        /// <summary>
        /// Returns the rank of this card
        /// </summary>
        /// <returns></returns>
        Rank GetRank()
        {
            return null;
        }

        /// <summary>
        /// Returns the suit of this card
        /// </summary>
        /// <returns></returns>
        Suit GetSuit()
        {
            return null;
        }

        /// <summary>
        /// Returns a descripton of this card
        /// </summary>
        /// <returns></returns>
        String ToString()
        {
            return "";
        }
    }
}
