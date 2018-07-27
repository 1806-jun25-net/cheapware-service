﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CheapWare.API.Controllers
{
    [Route("api/ComputerCases")]
    [ApiController]
    public class ComputerCasesController : ControllerBase
    {
        // GET: api/ComputerCases
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetComputerCases()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ComputerCases/5
        [HttpGet("{id}", Name = "GetComputerCasesById")]
        public ActionResult<string> GetComputerCasesById(int id)
        {
            return "value";
        }

        // POST: api/ComputerCases
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/ComputerCases/5
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
