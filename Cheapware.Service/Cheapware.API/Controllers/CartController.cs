﻿using System;
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

        //[Route("api/Cart/customerId/{customerId}")]
        [HttpGet("{customerId}", Name = "GetCartByCustomerId")]
        public async Task<ActionResult<List<Inventory>>> GetCartByCustomerId(int id)
        {
            return await repo.GetCartByCustomerId(id);
        }

       //[Route("api/Cart/cartId/{cartId}")]
       [HttpGet("{cartId}", Name = "GetCartById")]
       public async Task<ActionResult<Cart>> GetCartById(int id)
       {
            return await repo.GetCartById(id);
       }
        // POST: api/Orders
        [HttpPost]
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