using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CheapWare.API.Controllers
{
    [Route("api/GraphicsCards")]
    [ApiController]
    public class GraphicsCardsController : ControllerBase
    {
        // GET: api/GraphicsCards
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetGraphicsCards()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/GraphicsCards/5
        [HttpGet("{id}", Name = "GetGraphicsCardsById")]
        public ActionResult<string> GetGraphicsCardsById(int id)
        {
            return "value";
        }

        // POST: api/GraphicsCards
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/GraphicsCards/5
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
