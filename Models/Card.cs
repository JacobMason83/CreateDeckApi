using System;

namespace CreateDeckApi.Models
{
    public class Card(int number,int suit)
    {
        public int Number { get; set; } =number ;
        public int Suit{ get; set; } = suit;
    
    }
    public enum Suits
    {
        Hearts,
        Diamonds,
        Spades,
        Clubs
    }
    public enum Values 
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King

    }
}