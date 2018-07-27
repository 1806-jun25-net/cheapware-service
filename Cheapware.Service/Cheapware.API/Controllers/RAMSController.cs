using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CheapWare.API.Controllers
{
    [Route("api/RAMs")]
    [ApiController]
    public class RAMsController : ControllerBase
    {
        // GET: api/RAMS
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetRAMs()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/RAMS/5
        [HttpGet("{id}", Name = "GetRAMsById")]
        public ActionResult<string> GetRAMsById(int id)
        {
            return "value";
        }

        // POST: api/RAMS
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/RAMS/5
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
