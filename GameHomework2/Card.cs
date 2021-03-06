﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHomework2
{
    class Card
    {
        Suit heldSuit;
        Rank heldRank;

        public Card(Suit suit, Rank rank)
        {
            heldSuit = suit;
            heldRank = rank;
        }

        /// <summary>
        ///  Returns a 0 if the cards are the same, -1 if this card would be sorted lower than the other card, 
        ///  1 if this object would be sorted higher than the other card
        /// </summary>
        /// <param name="OtherCardObject"></param>
        /// <returns></returns>
        public int CompareTo(Card OtherCardObject)
        {
            if (this.GetSuit().CompareTo(OtherCardObject.GetSuit()) == 0)
            {
                return (this.GetRank().CompareTo(OtherCardObject.GetRank()));
            }
            else if (this.GetSuit().CompareTo(OtherCardObject.GetSuit()) == -1)
            {
                return -1;
            }
            else if (this.GetSuit().CompareTo(OtherCardObject.GetSuit()) == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Returns the rank of this card
        /// </summary>
        /// <returns></returns>
        public Rank GetRank()
        {
            return heldRank;
        }

        /// <summary>
        /// Returns the suit of this card
        /// </summary>
        /// <returns></returns>
        public Suit GetSuit()
        {
            return heldSuit;
        }

        /// <summary>
        /// Returns a descripton of this card
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "The " + (this.heldRank) + " of " + (this.heldSuit);
        }
    }
}
