using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// Programming Assignment 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Deals 2 cards to 3 players and displays cards for players
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // print welcome message
            Console.WriteLine("Welcome to the Playing Cards Console Application!!");

            //Shuffle Card Deck
            Deck cardDeck = ShuffleCardDeck();

            // deal 2 cards each to 3 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player)
            Card player1Card1=  cardDeck.TakeTopCard();
            Card player2Card1 = cardDeck.TakeTopCard();
            Card player3Card1 = cardDeck.TakeTopCard();
            Card player1Card2 = cardDeck.TakeTopCard();
            Card player2Card2 = cardDeck.TakeTopCard();
            Card player3Card2 = cardDeck.TakeTopCard();

            // flip all the cards over
            Console.WriteLine("The players dealt cards are flipover");
            player1Card1.FlipOver();
            player2Card1.FlipOver();
            player3Card1.FlipOver();
            player1Card2.FlipOver();
            player2Card2.FlipOver();
            player3Card2.FlipOver();
            Console.WriteLine();

            // print the cards for player 1
            Console.WriteLine("Player1 Dealt Card Details:");
            Console.WriteLine(player1Card1.Rank + " of " + player1Card1.Suit);
            Console.WriteLine(player1Card2.Rank + " of " + player1Card2.Suit);
            Console.WriteLine();

            // print the cards for player 2
            Console.WriteLine("Player2 Dealt Card Details:");
            Console.WriteLine(player2Card1.Rank + " of " + player2Card1.Suit);
            Console.WriteLine(player2Card2.Rank + " of " + player2Card2.Suit);
            Console.WriteLine();

            // print the cards for player 3
            Console.WriteLine("Player3 Dealt Card Details:");
            Console.WriteLine(player3Card1.Rank + " of " + player3Card1.Suit);
            Console.WriteLine(player3Card2.Rank + " of " + player3Card2.Suit);
            Console.WriteLine();
        }

        /// <summary>
        /// Shuffle Card Deck
        /// </summary>
        /// <returns></returns>
        private static Deck ShuffleCardDeck()
        {
        // create and shuffle a deck
            Deck cardDeck = new Deck();
            cardDeck.Shuffle();
            return cardDeck;
        }
    }
}
