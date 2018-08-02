using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cheapware.Library.Models;
using Cheapware.Library.RepoClasses;

namespace CheapWare.API.Controllers
{
    public class CartController : Controller
    {
        private ComputerRepo repo { get; }


        public CartController(ComputerRepo _repo)
        {
            repo = _repo;
        }

        [HttpGet("{id}", Name = "GetCartByCustomerId")]
        public ActionResult<Cart> GetCartByCustomerId(int id)
        {
            return repo.GetCartByCustomerId(id);
        }


        [HttpGet("{customerId}", Name = "GetOrdersByCustomerId")]
        public ActionResult<List<PartsOrder>> GetOrdersByCustomerId(int id)
        {
            return repo.GetOrdersByCustomerId(id);
        }

        // POST: api/Orders
        [HttpPost]
        public ActionResult Post(PartsOrder order)
        {
            repo.AddOrder(order);
            repo.Save();

            return CreatedAtRoute("GetOrderById", new { id = order.OrderId }, order);
        }
    }
}