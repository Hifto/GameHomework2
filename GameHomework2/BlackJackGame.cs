using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHomework2
{
    class BlackJackGame
    {
        private static readonly Random rng = new Random();

        public static string PlayGame()
        {
            BlackJackHand userHand = new BlackJackHand();
            BlackJackHand compHand = new BlackJackHand();

            Deck deck = new Deck();

            //Creates six sets of a standard 52 card deck
            for (int n = 0; n < 6; n++)
            {
                for (int o = 0; o < Suit.VALUES.Count; o++)
                {
                    for (int p = 0; p < Rank.VALUES.Count; p++)
                    {
                        Card card = new Card(Suit.VALUES[o], Rank.VALUES[p]);
                        deck.AddCard(card);
                    }
                }
            }

            //Play Blackjack

            int indexValue = 0;

            //Welcome message
            Console.WriteLine("\n");
            Console.WriteLine("Welcome to BlackJack!\n");

            deck.Shuffle();

            //Adds starting cards to hand for user
            userHand.AddCard(deck.DealOne());
            Console.WriteLine("You have been dealt the: " + userHand.GetCardAtIndex(0).GetRank().GetName() + " of " + userHand.GetCardAtIndex(0).GetSuit().GetName() + ".\n");
            userHand.AddCard(deck.DealOne());
            Console.WriteLine("You have been dealt the: " + userHand.GetCardAtIndex(1).GetRank().GetName() + " of " + userHand.GetCardAtIndex(1).GetSuit().GetName() + ".\n");

            //Gives starting total for user
            Console.WriteLine("Your current total is: " + userHand.EvaluateHand());

            Console.WriteLine("Hit or Stand (H/S)?");

            string answer = Console.ReadLine().ToUpper();

            if (answer.Equals("H"))
            {
                indexValue = 2;

                for (int n = 0; n < deck.deckList.Count; n++)
                {
                    userHand.AddCard(deck.DealOne());
                    Console.WriteLine("You have been dealt the: " + userHand.GetCardAtIndex(indexValue).GetRank().GetName() + " of " + userHand.GetCardAtIndex(indexValue).GetSuit().GetName() + ".\n");
                    indexValue++;

                    Console.WriteLine("Your current total is: " + userHand.EvaluateHand() + "\n");

                    if (userHand.EvaluateHand() > 21)
                    {
                        Console.WriteLine("The computer wins!");
                        return "The computer wins!";
                    }

                    Console.WriteLine("Hit or Stand (H/S)?");

                    answer = Console.ReadLine().ToUpper();

                    if (answer.Equals("S"))
                    {
                        break;
                    }
                }
            }

            //Adds starting cards to hand for computer
            compHand.AddCard(deck.DealOne());
            Console.WriteLine("The computer was dealt the: " + compHand.GetCardAtIndex(0).GetRank().GetName() + " of " + compHand.GetCardAtIndex(0).GetSuit().GetName() + ".\n");
            compHand.AddCard(deck.DealOne());
            Console.WriteLine("The computer was dealt the: " + compHand.GetCardAtIndex(1).GetRank().GetName() + " of " + compHand.GetCardAtIndex(1).GetSuit().GetName() + ".\n");

            //Logic begins to decide if computer should hit or stand
            indexValue = 2;

            for (int n = 0; n < deck.deckList.Count; n++)
            {
                if (compHand.EvaluateHand() < 17)
                {
                    compHand.AddCard(deck.DealOne());
                    Console.WriteLine("The computer was dealt the: " + compHand.GetCardAtIndex(indexValue).GetRank().GetName() + " of " + compHand.GetCardAtIndex(indexValue).GetSuit().GetName() + ".\n");
                    indexValue++;
                }
                else
                {
                    break;
                }

                if (compHand.EvaluateHand() > 21)
                {
                    Console.WriteLine("The computer's total is: " + compHand.EvaluateHand() + "\n");
                    Console.WriteLine("You win!");
                    return "You win!";
                }
            }

            Console.WriteLine("Your total is: " + userHand.EvaluateHand() + "\n");
            Console.WriteLine("The computer's total is: " + compHand.EvaluateHand() + "\n");

            //Compare both user and computer hands to decide winner
            if (userHand.CompareTo(compHand) == 0)
            {
                Console.WriteLine("It's a tie!");
                return "It's a tie!";
            }
            else if (userHand.CompareTo(compHand) == -1)
            {
                Console.WriteLine("The computer wins!");
                return "The computer wins!";
            }
            else if (userHand.CompareTo(compHand) == 1)
            {
                Console.WriteLine("You win!");
                return "You win!";
            }
            else
            {
                return "";
            }
        }
    }
}
