using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHomework2
{
    class Rank
    {
        static string TWO = "2";
        static string THREE = "3";
        static string FOUR = "4";
        static string FIVE = "5";
        static string SIX = "6";
        static string SEVEN = "7";
        static string EIGHT = "8";
        static string NINE = "9";
        static string TEN = "10";
        static string JACK = "J";
        static string QUEEN = "Q";
        static string KING = "K";
        static string ACE = "A";
        static List<Rank> VALUES;

        /// <summary>
        /// Returns 0 is the ranks are the same, -1 if this object has
        /// a lower rank than the other, 1 if this object has a higher
        /// rank than the other
        /// </summary>
        /// <param name="OtherRankObject"></param>
        /// <returns></returns>
        int CompareTo(Rank OtherRankObject)
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
