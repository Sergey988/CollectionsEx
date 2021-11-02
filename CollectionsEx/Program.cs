using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsEx

{            //Task 4:
             //Realize the functionality of card deck based on the Queue collection.
             //Write the next methods: get the card from the deck, distribution of 6 cards, shuffle the deck etc.
    class Program
    {

        static Queue<string> NewDeck()
        {
            string[] suits = new string[] { "\u2665", "\u2666", "\u2663", "\u2660" };
            string[] valueCards = new string[] { "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            Queue<string> deck = new Queue<string>();

            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < valueCards.Length; j++)
                {
                    deck.Enqueue($"{valueCards[j]}{suits[i]}");
                }
            }
            return deck;
        }
        static void PrintDeck(Queue<string> deck)
        {
            Console.WriteLine("Show deck");
            foreach (var item in deck)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        static string GetCardFromTheDeck(Queue<string> deck, int number)
        {
            string card = "";
            string[] arrDeck = new string[number];
            
            for (int i = 0; i <= number-1; i++)
            {
                if (i == number-1)
                {
                    card = "You get - " + deck.Peek();
                }
                arrDeck[i] = deck.Dequeue();
            }

            foreach (var item in arrDeck)
                deck.Enqueue(item);

            return card;
        }

        static void ShuffleTheDeck(Queue<string> deck)
        {
            Console.WriteLine("\nShuffle");
            string[] arrDeck = new string[deck.Count];
            for (int i = 0; i < arrDeck.Length; i++)
                arrDeck[i] = deck.Dequeue();

            Random random = new Random();
            arrDeck = arrDeck.OrderBy(x => random.Next()).ToArray();

            foreach (var item in arrDeck)
                deck.Enqueue(item);



        }

        static void Distribution(Queue<string>deck, int players, int cardOfEachPlayer)
        {
            Console.WriteLine($"\nDistribution for {players} players, {cardOfEachPlayer} cards each");
            string[,] arrPlayers = new string[players,36/players];
            
            int l = cardOfEachPlayer;
            int k = 0;
            int i = 0;
            while (deck.Count > 0)
            {
                for (int j = k; j <= cardOfEachPlayer-1; j++)
                    arrPlayers[i, j] = deck.Dequeue();

                i++;

                if (i == players)
                {
                    k = k + l;
                    cardOfEachPlayer += l;
                    i = 0;
                }
            }

            Console.WriteLine();
            for (int m = 0; m < players; m++)
            {
                Console.Write($"Player{m+1} - ");
                for (int j = 0; j < 36/players; j++)
                    Console.Write($"{arrPlayers[m, j]} ");
 
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {


            Queue<string> deck = NewDeck();
            PrintDeck(deck);
            Console.WriteLine();


            //GetCardFromTheDeck(Queue<string>deck, cardNumber)
            Console.WriteLine(GetCardFromTheDeck(deck, 5));

            PrintDeck(deck);

            ShuffleTheDeck(deck);
            PrintDeck(deck);

            //Distribution(Queue<string>deck, int players, int cardOfEachPlayer);
            
            Distribution(deck, 6, 6);
            //Distribution(deck, 2, 3);
            //Distribution(deck, 4, 9);


            //Queue<string> deck2 = NewDeck();
            //PrintDeck(deck2);
            //ShuffleTheDeck(deck2);
            //PrintDeck(deck2);

        }
    }
}
