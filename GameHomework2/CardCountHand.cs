using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHomework2
{
    class CardCountHand : Hand
    {
        /// <summary>
        /// Compares two hands to determine which hand is greater. Return 0 if there is a draw, -1 if this hand is lower than the other hand,
        /// and 1 if this hand is larger than the other hand
        /// </summary>
        /// <param name="OtherHandObject"></param>
        /// <returns></returns>
        public override int CompareTo(Hand OtherHandObject)
        {
            if (this.EvaluateHand() == OtherHandObject.EvaluateHand())
            {
                return 0;
            }
            else if (this.EvaluateHand() < OtherHandObject.EvaluateHand())
            {
                return -1;
            }
            else if (this.EvaluateHand() > OtherHandObject.EvaluateHand())
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Takes a hand and totals up the point values
        /// </summary>
        /// <returns></returns>
        public override int EvaluateHand()
        {
            int total = 0;
            int count = 0;

            foreach (Card element in this.listOfCards)
            {
                if (this.GetCardAtIndex(count).GetRank() == Rank.ACE)
                {
                    total += 1;
                }
                else if (this.GetCardAtIndex(count).GetRank() == Rank.TWO)
                {
                    total += 2;
                }
                else if (this.GetCardAtIndex(count).GetRank() == Rank.THREE)
                {
                    total += 3;
                }
                else if (this.GetCardAtIndex(count).GetRank() == Rank.FOUR)
                {
                    total += 4;
                }
                else if (this.GetCardAtIndex(count).GetRank() == Rank.FIVE)
                {
                    total += 5;
                }
                else if (this.GetCardAtIndex(count).GetRank() == Rank.SIX)
                {
                    total += 6;
                }
                else if (this.GetCardAtIndex(count).GetRank() == Rank.SEVEN)
                {
                    total += 7;
                }
                else if (this.GetCardAtIndex(count).GetRank() == Rank.EIGHT)
                {
                    total += 8;
                }
                else if (this.GetCardAtIndex(count).GetRank() == Rank.NINE)
                {
                    total += 9;
                }
                else if (this.GetCardAtIndex(count).GetRank() == Rank.TEN)
                {
                    total += 10;
                }
                else if (this.GetCardAtIndex(count).GetRank() == Rank.JACK)
                {
                    total += 10;
                }
                else if (this.GetCardAtIndex(count).GetRank() == Rank.QUEEN)
                {
                    total += 10;
                }
                else if (this.GetCardAtIndex(count).GetRank() == Rank.KING)
                {
                    total += 10;
                }

                count++;
            }

            return total;
        }
    }
}
