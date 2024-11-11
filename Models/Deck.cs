using System;
using CreateDeckApi.Models;
namespace CreateDeckApi.Models;


    public class Deck
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


        public void ShuffleDeck()
        { 
           var rng = new Random();
           var deck = Cards;
        rng.Shuffle<Card>(deck);
         this.Cards = deck;
        }
        // will need create the deck
        // will then need to shuffle the deck
    }
