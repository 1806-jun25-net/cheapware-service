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
    [Route("api/MotherBoards")]
    [ApiController]
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
        public ActionResult<List<MotherBoard>> GetMotherBoards()
        {

            return repo.GetMotherBoards();
        }

        // GET api/values/5
        [HttpGet("{name}", Name = "GetMotherBoardByName")]
        public ActionResult<MotherBoard> GetCPUsByName(string name)
        {

            return repo.GetMotherBoardByName(name);
        }
    }
}