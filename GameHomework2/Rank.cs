using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHomework2
{
    public class Rank
    {
        public static Rank TWO;
        public static Rank THREE;
        public static Rank FOUR;
        public static Rank FIVE;
        public static Rank SIX;
        public static Rank SEVEN;
        public static Rank EIGHT;
        public static Rank NINE;
        public static Rank TEN;
        public static Rank JACK;
        public static Rank QUEEN;
        public static Rank KING;
        public static Rank ACE;
        public static List<Rank> VALUES;

        string storeName;
        string storeSymbol;
        int storeValue;

        static Rank()
        {
            VALUES = new List<Rank>();
            TWO = new Rank("Two", "2", 2);
            THREE = new Rank("Three", "3", 3);
            FOUR = new Rank("Four", "4", 4);
            FIVE = new Rank("Five", "5", 5);
            SIX = new Rank("Six", "6", 6);
            SEVEN = new Rank("Seven", "7", 7);
            EIGHT = new Rank("Eight", "8", 8);
            NINE = new Rank("Nine", "9", 9);
            TEN = new Rank("Ten", "10", 10);
            JACK = new Rank("Jack", "J", 11);
            QUEEN = new Rank("Queen", "Q", 12);
            KING = new Rank("King", "K", 13);
            ACE = new Rank("Ace", "A", 14);
        }

        public Rank(string name, string symbol, int value)
        {
            storeName = name;
            storeSymbol = symbol;
            storeValue = value;

            VALUES.Add(this);
        }

        /// <summary>
        /// Returns 0 if the ranks are the same, -1 if this object has
        /// a lower rank than the other, 1 if this object has a higher
        /// rank than the other
        /// </summary>
        /// <param name="OtherRankObject"></param>
        /// <returns></returns>
        public int CompareTo(Rank OtherRankObject)
        {
            if (this.storeValue == OtherRankObject.storeValue)
            {
                return 0;
            }
            else if (this.storeValue < OtherRankObject.storeValue)
            {
                return -1;
            }
            else if (this.storeValue > OtherRankObject.storeValue)
            {
                return 1;
            }
            else
            {
                return 0;
            }
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
        /// Name associated with the rank
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
            return storeSymbol;
        }
    }
}
