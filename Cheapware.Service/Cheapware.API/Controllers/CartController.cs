﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cheapware.Library.Models;
using Cheapware.Library.RepoClasses;
using Microsoft.AspNetCore.Authorization;

namespace CheapWare.API.Controllers
{
    [Route("api/Cart/")]
    [ApiController]
    [Authorize]
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
        [Route("CartIdsByCustomer/{customerId}", Name = "CartIdsByCustomer")]
        public async Task<ActionResult<List<Cart>>> CartIdsByCustomer(int customerId)
        {
            return await repo.CartIdsByCustomer(customerId);
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
        [Route("DeleteByCartId/{cartId}", Name ="DeleteByCartId")]
        public async Task DeleteByCartId(int cartId)
        {
            await repo.DeleteByCartId(cartId);
            await repo.Save();
        }
        [HttpDelete]
        public async Task Delete(int id)
        {
            await repo.DeleteCartByCustomer(id);
            await repo.Save();
        }
        
    }
}