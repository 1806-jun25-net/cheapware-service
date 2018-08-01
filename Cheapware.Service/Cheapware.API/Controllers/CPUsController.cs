using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cheapware.Library.Models;
using Cheapware.Data.Models;
using Cheapware.Library.RepoClasses;
namespace CheapWare.API.Controllers
{
    [Route("api/CPUs")]
    [ApiController]
    public class CPUsController : ControllerBase
    {
        private ComputerRepo repo { get; }

        public CPUsController(ComputerRepo _repo)
        {
            repo = _repo;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<List<CPU>> GetAll()
        {

            return repo.GetCpus();
        }

        // GET api/values/5
        [HttpGet("{name}", Name = "GetCPUsByName")]
        public ActionResult<CPU> GetCPUsByName(string name)
        {

            return repo.GetCpuByName(name);
        }

    }
}