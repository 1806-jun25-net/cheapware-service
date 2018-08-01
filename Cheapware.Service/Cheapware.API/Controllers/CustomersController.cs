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
        private ComputerRepo repo { get; }                                                                             

        public CustomersController(ComputerRepo _repo)
        {
            repo = _repo;
        }

        // GET: api/Customers
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> GetCustomers()
        {
            return repo.GetCustomers();
        }

        // GET: api/Customers/5
        [HttpGet("{id}", Name = "GetCustomerById")]
        public ActionResult<Customer> GetCustomerById(int id)
        {
            return repo.GetCustomerById(id);
        }

        // POST: api/Customers
        [HttpPost]
        public ActionResult Post(Customer customer)
        {
            repo.AddCustomer(customer);
            repo.Save();

            return CreatedAtRoute("GetCustomersById", new { id = customer.CustomerId }, customer);
        }

        
    }
}
