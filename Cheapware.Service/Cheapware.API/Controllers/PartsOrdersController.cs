using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cheapware.Library.Models;
using Cheapware.Library.RepoClasses;
namespace CheapWare.API.Controllers
{
    [Route("api/Orders")]
    [ApiController]
    public class PartsOrdersController : Controller
    {
        private ComputerRepo repo { get; }


        public PartsOrdersController(ComputerRepo _repo)
        {
            repo = _repo;
        }

        [HttpGet("{id}", Name = "GetOrderById")]
        public async Task<ActionResult<PartsOrder>> GetOrderById(int id)
        {
            return await repo.GetOrderById(id);
        }


        [HttpGet("{customerId}", Name = "GetOrdersByCustomerId")]
        public async Task<ActionResult<List<PartsOrder>>> GetOrdersByCustomerId(int id)
        {
            return await repo.GetOrdersByCustomerId(id);
        }

        // POST: api/Orders
        [HttpPost]
        public async Task<ActionResult> Post(PartsOrder order)
        {
            repo.AddOrder(order);
            await repo.Save();

            return CreatedAtRoute("GetOrderById", new { id = order.OrderId }, order);
        }


    }
}