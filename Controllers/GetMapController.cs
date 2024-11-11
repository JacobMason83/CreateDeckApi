using Microsoft.AspNetCore.Mvc;
using CreateDeckApi.Models;
using System.ComponentModel;


namespace CreateDeckApi.Controllers;

[ApiController]
[Route("[Controller]")]
public class GetMapController : ControllerBase
{

    [HttpGet(Name = "GetCards")]
    public Deck Get()
    {
     var deck = new Deck();
     deck.ShuffleDeck();
        return deck;
    }
    }

