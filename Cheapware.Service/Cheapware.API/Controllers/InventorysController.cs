using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cheapware.Library.RepoClasses;
using Cheapware.Library.Models;
using Microsoft.AspNetCore.Authorization;

namespace CheapWare.API.Controllers
{
    [Route("api/Inventorys/")]
    [ApiController]
    [Authorize]
    public class InventorysController : ControllerBase
    {
        // GET: api/GraphicsCardsC:\Revature\cheapware-service\Cheapware.Service\Cheapware.API\Controllers\InventorysController.cs
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
        [HttpPut]
        [Route("UpdateInventory", Name ="UpdateInventory")]
        public async Task UpdateInventory(Inventory inv)
        {
            repo.UpdateInventory(inv);
            await repo.Save();
        }

        // GET: api/GraphicsCards/5


        [HttpGet("{category}", Name = "GetInventoryByCategory")]
        public async Task<ActionResult<List<Inventory>>> GetInventoryByCategory(string cat)
        {
            return await repo.GetInventoryByCategory(cat);
        }

        [HttpGet]
        [Route("Search", Name = "GetInventoryBySearch")]
        public async Task<ActionResult<List<Inventory>>> GetInventoryBySearch([FromQuery]string search = null)
        {
            return await repo.GetInventoryBySearch(search);
        }
    }
}
