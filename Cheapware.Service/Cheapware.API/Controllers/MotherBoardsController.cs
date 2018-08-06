using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cheapware.Library.Models;
using Cheapware.Library.RepoClasses;
using Microsoft.AspNetCore.Authorization;

namespace CheapWare.API.Controllers
{
    [Route("api/MotherBoards")]
    [ApiController]
    [Authorize]
    public class MotherBoardsController : ControllerBase
    {
        // GET api/values
        
        private ComputerRepo repo { get; }

        public MotherBoardsController(ComputerRepo _repo)
        {
            repo = _repo;
        }
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<List<MotherBoard>>> GetMotherBoards()
        {

            return await repo.GetMotherBoards();
        }

        // GET api/values/5
        [HttpGet("{name}", Name = "GetMotherBoardByName")]
        public async Task<ActionResult<MotherBoard>> GetMotherBoardByName(string name)
        {
            return await repo.GetMotherBoardByName(name);
        }
    }
}