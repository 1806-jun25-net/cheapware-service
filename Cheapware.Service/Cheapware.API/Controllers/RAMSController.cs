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
        public ActionResult<List<RAM>> GetRams()
        {

            return repo.GetRams();
        }

        // GET api/values/5
        [HttpGet("{name}", Name = "GetRamByName")]
        public ActionResult<RAM> GetRamByName(string name)
        {

            return repo.GetRamByName(name);
        }
    }
}
