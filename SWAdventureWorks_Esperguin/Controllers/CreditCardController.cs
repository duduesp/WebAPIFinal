using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SWAdventureWorks_Esperguin.Models;

namespace SWAdventureWorks_Esperguin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditCardController : ControllerBase
    {
        private readonly AdventureWorks2019Context context;

        public CreditCardController(AdventureWorks2019Context context)

        {
            this.context = context; 
        }

        // GET api/creditcard

        [HttpGet]

        public ActionResult<IEnumerable<CreditCard>> Get()
        {
            return context.CreditCard.ToList();
        }

        //GET BY ID
        //GET: api/creditcard/2

        [HttpGet("{id}")]
        public ActionResult<CreditCard> GetById(int id)
        {
            CreditCard creditCard = (from a in context.CreditCard
                               where a.CreditCardId == id
                               select a).SingleOrDefault();
            return creditCard;
        }

        // GET by CardType

        [HttpGet("type/{cardType}")]

        public ActionResult<IEnumerable<CreditCard>> GetByTipe(string cardType)
        {
            List<CreditCard> creditCards = (from a in context.CreditCard
                                 where a.CardType == cardType
                                 select a).ToList();
            return creditCards;
        }



        //POST api/cardtype
        [HttpPost]
        public ActionResult Post(CreditCard creditCard)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.CreditCard.Add(creditCard);
            context.SaveChanges();
            return Ok();
        }
    }
}
