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
    [Route("api/GraphicsCards")]
    [ApiController]
    public class GraphicsCardsController : ControllerBase
    {
        // GET: api/GraphicsCards
        private ComputerRepo repo { get; }

        public GraphicsCardsController(ComputerRepo _repo)
        {
            repo = _repo;
        }
        [HttpGet]
        public ActionResult<IEnumerable<GraphicsCard>> GetGraphicsCards()
        {
            return repo.GetGraphicsCards();
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
