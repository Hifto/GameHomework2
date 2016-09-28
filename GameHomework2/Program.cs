using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHomework2
{
    class Program
    {
        public static void Main(string[] args)
        {
            // play a CardCountGame
            CardCountGame.PlayGame();

            //play a BlackJackGame
            BlackJackGame.PlayGame();

            Console.ReadLine();
        }
    }
}