using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CheapWare.API.Controllers
{
    [Route("api/PartsOrders")]
    [ApiController]
    public class PartsOrdersController : ControllerBase
    {
        // GET: api/PartsOrders
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetPartsOrders()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/PartsOrders/5
        [HttpGet("{id}", Name = "GetPartsOrdersById")]
        public ActionResult<string> GetPartsOrdersById(int id)
        {
            return "value";
        }

        // POST: api/PartsOrders
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/PartsOrders/5
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
