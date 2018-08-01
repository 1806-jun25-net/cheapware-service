using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cheapware.Library.Models;
using Cheapware.Library.RepoClasses;
namespace CheapWare.API.Controllers
{
    public class PartsOrdersController : Controller
    {
        private ComputerRepo repo { get; }

        public PartsOrdersController(ComputerRepo _repo)
        {
            repo = _repo;
        }

        // GET: api/Customers
        

        // GET: api/Customers/5
        [HttpGet("{id}", Name = "GetOrdersByCustomerId")]
        public ActionResult<List<PartsOrder>> GetOrdersByCustomerId(int id)
        {


            return repo.GetOrdersByCustomerId(id);
        }

        // POST: api/Customers
        [HttpPost]
        public ActionResult Post(PartsOrder order)
        {
            repo.AddOrder(order);
            repo.Save();

            return CreatedAtRoute("GetCustomersById", new { id = order.OrderId }, order);
        }

       
    }
}