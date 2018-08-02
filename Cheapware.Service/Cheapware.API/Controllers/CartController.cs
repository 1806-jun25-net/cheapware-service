using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cheapware.Library.Models;
using Cheapware.Library.RepoClasses;

namespace CheapWare.API.Controllers
{
    [Route("api/Cart")]
    [ApiController]
    public class CartController : Controller
    {
        private ComputerRepo repo { get; }


        public CartController(ComputerRepo _repo)
        {
            repo = _repo;
        }

        [HttpGet("{id}", Name = "GetCartByCustomerId")]
        public ActionResult<List<Cart>> GetCartByCustomerId(int id)
        {
            return repo.GetCartByCustomerId(id);
        }


       [HttpGet("cartId", Name = "GetCartById")]
       public ActionResult<Cart> GetCartById(int id)
       {
            return repo.GetCartById(id);
       }
        // POST: api/Orders
        [HttpPost]
        public ActionResult Post(Cart cart)
        {
            repo.AddCart(cart);
            repo.Save();

            return CreatedAtRoute("GetCartById", new { id = cart.CartId }, cart);
        }

        
    }
}