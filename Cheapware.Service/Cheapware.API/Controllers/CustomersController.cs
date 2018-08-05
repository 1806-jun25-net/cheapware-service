using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cheapware.Library.RepoClasses;
using Cheapware.Library.Models;

namespace CheapWare.API.Controllers
{
    [Route("api/Customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private ComputerRepo repo { get; }                                                                             

        public CustomersController(ComputerRepo _repo)
        {
            repo = _repo;
        }

        // GET: api/Customers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        {
            return await repo.GetCustomers();
        }

        // GET: api/Customers/5
        
        
        [HttpGet("{userName}", Name = "GetCustomerIdByUserName")]
        public async Task<ActionResult<int>> GetCustomerIdByUserName(string username)
        {
            var user = await repo.GetCustomerByUserName(username);

            return user.CustomerId;
        }
        [HttpGet("{customerId}", Name = "GetCustomerById")]
        public async Task<ActionResult<Customer>> GetCustomerById(int id)
        {
            return await repo.GetCustomerById(id);
        }
        // POST: api/Customers
        [HttpPost]
        public async Task<ActionResult> Post(Customer customer)
        {
            repo.AddCustomer(customer);
            await repo.Save();

            return CreatedAtRoute("GetCustomersById", new { id = customer.CustomerId }, customer);
        }

        
    }
}
