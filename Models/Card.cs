using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateDeckApi.Models
{
    public class Card(int number,int suit)
    {
        public int number { get; set; } = number;
        public int suit{ get; set; } =  suit;
    
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