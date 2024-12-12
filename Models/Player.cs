namespace CreateDeckApi.Models
{
    public class Player 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Card[] Cards { get; set; } // this sets the cards of the user to an array of Card Class

    }
}