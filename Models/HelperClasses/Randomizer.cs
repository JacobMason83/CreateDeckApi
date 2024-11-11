using CreateDeckApi.Models;

namespace CreateDeckApi.Models.HelperClasses
{
    static class Randomizer
    {
 
      public static Deck? ShuffleDeck(Deck? deck)
      {
        Random rng = new Random ();
        Deck? array = deck;
         int n = array.Length;
        while (n > 1) 
        {
            int k = rng.Next(n--);
            Deck[] temp = array[n];
            array[n] = array[k];
            array[k] = temp;
        }
       return array;
         
   
      }
    }
}