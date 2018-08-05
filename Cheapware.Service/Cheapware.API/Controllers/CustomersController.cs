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
    [Route("api/Customers/")]
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
        [Route("GetAll", Name = "GetAll")]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        {
            return await repo.GetCustomers();
        }

        [HttpGet]
        [Route("GetCustomerById/{id}", Name = "GetCustomerById")]
        public async Task<ActionResult<Customer>> GetCustomerById(int id)
        {
            return await repo.GetCustomerById(id);
        }

        [HttpGet]
        [Route("GetCustomerByUserName/{UserName}")]
        public async Task<ActionResult<Customer>> GetCustomerByUserName(string UserName)
        {

            return await repo.GetCustomerByUserName(UserName);
        }
      
        // POST: api/Customers
        [HttpPost]
        public async Task<ActionResult> Post(Customer customer)
        {
            repo.AddCustomer(customer);
            await repo.Save();

            return CreatedAtRoute("GetCustomerById", new { id = customer.CustomerId }, customer);
        }

        
    }
}
