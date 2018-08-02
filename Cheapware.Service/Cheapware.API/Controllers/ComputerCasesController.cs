using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cheapware.Library.RepoClasses;
using Cheapware.Data.Models;
using Cheapware.Library.Models;
namespace CheapWare.API.Controllers
{
    [Route("api/ComputerCases")]
    [ApiController]
    public class ComputerCasesController : ControllerBase
    {
        private ComputerRepo repo { get; }
        // GET: api/ComputerCases
        public ComputerCasesController(ComputerRepo _repo)
        {
            repo = _repo;
        }
        [HttpGet]
        public async Task<ActionResult<List<ComputerCase>>> GetComputerCases()
        {
            return await repo.GetComputerCases();
        }

        // GET: api/ComputerCases/5
        [HttpGet("{name}", Name = "GetComputerCasesByName")]
        public async Task<ActionResult<ComputerCase>> GetComputerCasesByName(string name)
        {
            return await repo.GetComputerCaseByName(name);
        }

       
    }
}
