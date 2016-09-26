using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHomework2
{
    class Suit
    {
        public static Suit CLUBS;
        public static Suit DIAMONDS;
        public static Suit HEARTS;
        public static Suit SPADES;
        public static List<Suit> VALUES;

        string storeName;
        string storeSymbol;

        static Suit()
        {
            VALUES = new List<Suit>();
            CLUBS = new Suit("Club", "♣");
            DIAMONDS = new Suit("Diamond", "♦");
            HEARTS = new Suit("Heart", "♥");
            SPADES = new Suit("Spade", "♠");
        }

        public Suit(string name, string symbol)
        {
            storeName = name;
            storeSymbol = symbol;

            VALUES.Add(this);
        }

        /// <summary>
        /// Returns 0 if the ranks are the same, -1 if this object is
        /// lower than the other, 1 if this object is higher than the
        /// other
        /// </summary>
        /// <param name="OtherSuitObject"></param>
        /// <returns></returns>
        public int CompareTo(Suit OtherSuitObject)
        {
            return 0;
        }

        /// <summary>
        /// Symbol associated with the rank
        /// </summary>
        /// <returns></returns>
        public string GetSymbol()
        {
            return storeSymbol;
        }

        /// <summary>
        /// Name asscociated with the rank
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return storeName;
        }

        /// <summary>
        /// Override tostring method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return storeName;
        }
    }
}
