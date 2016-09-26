using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHomework2
{
    class Suit
    {
        static Suit CLUBS;
        static Suit DIAMONDS;
        static Suit HEARTS;
        static Suit SPADES;
        static List<Suit> VALUES;

        static Suit()
        {
            CLUBS = new Suit("Club", "♣");
            DIAMONDS = new Suit("Diamond", "♦");
            HEARTS = new Suit("Heart", "♥");
            SPADES = new Suit("Spade", "♠");
        }

        Suit(string name, string symbol)
        {
            VALUES.Add(this);
        }

        /// <summary>
        /// Returns 0 if the ranks are the same, -1 if this object is
        /// lower than the other, 1 if this object is higher than the
        /// other
        /// </summary>
        /// <param name="OtherSuitObject"></param>
        /// <returns></returns>
        int CompareTo(Suit OtherSuitObject)
        {

            return 0;
        }

        /// <summary>
        /// Symbol associated with the rank
        /// </summary>
        /// <returns></returns>
        string GetSymbol()
        {
            return "";
        }

        /// <summary>
        /// Name asscociated with the rank
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
