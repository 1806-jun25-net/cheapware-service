using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cheapware.Library.Models;
using Cheapware.Library.RepoClasses;

namespace CheapWare.API.Controllers
{
    [Route("api/Cart/")]
    [ApiController]
    public class CartController : Controller
    {
        private ComputerRepo repo { get; }


        public CartController(ComputerRepo _repo)
        {
            repo = _repo;
        }

        [HttpGet]
        [Route("cartByCustomer/{customerId}")]
        public async Task<ActionResult<List<Inventory>>> GetCartByCustomerId(int customerId)
        {
            return await repo.GetCartByCustomerId(customerId);
        }


        [HttpGet]
        [Route("cartById/{cartId}", Name = "GetCartById")]
        public async Task<ActionResult<Cart>> GetCartById(int cartId)
       {
            return await repo.GetCartById(cartId);
       }
        // POST: api/Orders
        [HttpPost]
        [Route("AddCart")]
        public async Task<ActionResult> AddToCart(Cart cart)
        {
            repo.AddCart(cart);
            await repo.Save();

            return CreatedAtRoute("GetCartById", new { cartId = cart.CartId }, cart);
        }

        [HttpDelete]
        public async Task Delete(int id)
        {
            await repo.DeleteCartByCustomer(id);
            await repo.Save();
        }
        
    }
}