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

        static Rank()
        {
            VALUES = new List<Rank>();
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

        public Rank(string name, string symbol)
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
        public int CompareTo(Rank OtherRankObject)
        {
            return 0;
        }

        /// <summary>
        /// Symbol associated with the rank
        /// </summary>
        /// <returns></returns>
        public string GetSymbol()
        {
            return "";
        }

        /// <summary>
        /// Name associated with the rank
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return "";
        }

        /// <summary>
        /// Override tostring method
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            return "";
        }
    }
}
