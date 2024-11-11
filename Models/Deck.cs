using System;
using CreateDeckApi.Models;
using SQLitePCL;
namespace CreateDeckApi.Models

{
    public class Deck : Card
    {
        public Card[] Cards { get; set; }
        public Deck()
        {
            List<Card> deck = new List<Card>();
            foreach (int value in Enum.GetValues(typeof(Values)))
            {
                foreach (int suit in Enum.GetValues(typeof(Suits)))
                {
                    var card = new Card(value, suit);
                    deck.Add(card);
                }
                Cards = deck.ToArray();
            }
        }


        public ShuffleDeck
        { 
           
            var shuffledDeck = rng.Shuffle(deck);
            return shuffledDeck;
        }
        // will need create the deck
        // will then need to shuffle the deck
    }
}