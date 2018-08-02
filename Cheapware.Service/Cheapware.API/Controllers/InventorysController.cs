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
    [Route("api/Inventorys")]
    [ApiController]
    public class InventorysController : ControllerBase
    {
        // GET: api/GraphicsCards
        private ComputerRepo repo { get; }

        public InventorysController(ComputerRepo _repo)
        {
            repo = _repo;
        }
        [HttpGet]
        public async Task<ActionResult<List<Inventory>>> GetInventory()
        {
            return await repo.GetInventory();
        }

        // GET: api/GraphicsCards/5


        [HttpGet("{category}", Name = "GetInventoryByCategory")]
        public async Task<ActionResult<List<Inventory>>> GetInventoryByCategory(string cat)
        {
            return await repo.GetInventoryByCategory(cat);
        }
    }
}
