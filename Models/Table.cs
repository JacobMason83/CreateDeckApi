// using System.Globalization;
// using Microsoft.CodeAnalysis.CSharp.Syntax;

// namespace CreateDeckApi.Models
// {
//     public class Table : Player
//     {
//         public int[] Players { get; set; } 
//         public required Deck[] Decks { get; set; } 
//         public Table(string[] newbie,string game){ // must be a list of one or more player names
//             List<Player> players = new List<Player>(); // get the players
//             Deck decks = new Deck(); // get the new deck
//             var gameType = Enum.GetName(typeof(Games), game);
//             var totalDealtCards = gameType;
           
//            decks.ShuffleDeck();
//             var index = 0;
//             foreach(var player in players) {
//                 var newPlayer = new Player();
//                 newPlayer.Name = newbie[index];
//                 var totalToDeal = game == "BlackJack" ? (int)Games.BlackJack : game == "TexasHoldem" ? (int)Games.TexasHoldem : (int)Games.SevenCardStud
//                 ;
//                 var totalDealt = 1;
              
//                 foreach(var card in decks.getDecks()) {
//                     if(totalDealt < totalToDeal)
//                     newPlayer.Cards[index] = card;
//                 }
//             }
//         }
//         public enum Games {
//             BlackJack = 2,
//             TexasHoldem = 5,
//             SevenCardStud = 7
//         }
//     }
// }