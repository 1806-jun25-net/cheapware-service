﻿using System;
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
        public CustomersRepo repo;
        // GET: api/Customers
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetCustomers()
        {
            return new List<string> { "bob", "dole" };
        }

        // GET: api/Customers/5
        [HttpGet("{id}", Name = "GetCustomersById")]
        public ActionResult<IEnumerable<string>> GetCustomersById(int id)
        {
            var customer = repo.GetCustomerById(1);

            return new List<string> { customer.CustomerName }; ;
        }

        // POST: api/Customers
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Customers/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
