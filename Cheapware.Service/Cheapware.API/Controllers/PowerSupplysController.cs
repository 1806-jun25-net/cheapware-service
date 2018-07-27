using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CheapWare.API.Controllers
{
    [Route("api/PowerSupplys")]
    [ApiController]
    public class PowerSupplysController : ControllerBase
    {
        // GET: api/PowerSupply
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetPowerSupplys()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/PowerSupply/5
        [HttpGet("{id}", Name = "GetPowerSupplysById")]
        public ActionResult<string> GetPowerSupplysById(int id)
        {
            return "value";
        }

        // POST: api/PowerSupply
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/PowerSupply/5
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
