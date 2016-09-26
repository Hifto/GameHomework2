using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHomework2
{
    class Rank
    {
        static Rank TWO;
        static Rank THREE;
        static Rank FOUR;
        static Rank FIVE;
        static Rank SIX;
        static Rank SEVEN;
        static Rank EIGHT;
        static Rank NINE;
        static Rank TEN;
        static Rank JACK;
        static Rank QUEEN;
        static Rank KING;
        static Rank ACE;
        static List<Rank> VALUES;

        static Rank()
        {
            TWO = new Rank("Two", "2");
            THREE = new Rank("Three", "3");
            FOUR = new Rank("Four", "4");
            FIVE = new Rank("Five", "5");
            SIX = new Rank("Six", "6");
            SEVEN = new Rank("Seven", "7");
            EIGHT = new Rank("Eight", "8");
            NINE = new Rank("Nine", "9");
            TEN = new Rank("Ten", "10");
            JACK = new Rank("Jack", "J");
            QUEEN = new Rank("Queen", "Q");
            KING = new Rank("King", "K");
            ACE = new Rank("Ace", "A");
        }

        Rank(string name, string symbol)
        {
            VALUES.Add(this);
        }

        /// <summary>
        /// Returns 0 if the ranks are the same, -1 if this object has
        /// a lower rank than the other, 1 if this object has a higher
        /// rank than the other
        /// </summary>
        /// <param name="OtherRankObject"></param>
        /// <returns></returns>
        int CompareTo(Rank OtherRankObject)
        {
            

            if (this == OtherRankObject)
            {
                return 0;
            }
            else if (this < OtherRankObject)
            {
                return -1;
            }
            else if (this > OtherRankObject)
            {
                return 1;
            }

            return 0;
        }

        /// <summary>
        /// Symbol associated with the rank
        /// </summary>
        /// <returns></returns>
        string GetSymbol()
        {
            
        }

        /// <summary>
        /// Name associated with the rank
        /// </summary>
        /// <returns></returns>
        string GetName()
        {
            return "";
        }

        /// <summary>
        /// Override tostring method
        /// </summary>
        /// <returns></returns>
        string ToString()
        {
            return "";
        }
    }
}
