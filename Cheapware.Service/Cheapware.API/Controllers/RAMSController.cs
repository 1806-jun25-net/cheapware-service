using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cheapware.Library.Models;
using Cheapware.Library.RepoClasses;
namespace CheapWare.API.Controllers
{
    [Route("api/RAMs")]
    [ApiController]
    public class RAMsController : ControllerBase
    {
        private ComputerRepo repo { get; }

        public RAMsController(ComputerRepo _repo)
        {
            repo = _repo;
        }
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<List<Ram>>> GetRams()
        {

            return await repo.GetRams();
        }

        // GET api/values/5
        [HttpGet("{name}", Name = "GetRamByName")]
        public async Task<ActionResult<Ram>> GetRamByName(string name)
        {

            return await repo.GetRamByName(name);
        }
    }
}
