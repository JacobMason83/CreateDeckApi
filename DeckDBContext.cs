using CreateDeckApi.Models;
using Microsoft.EntityFrameworkCore;
using System;

public class DeckDBContext : DbContext
{
    public DbSet<Card> Cards { get; set; }
    public DbSet<Deck> Decks { get; set; }
}