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
    [Route("api/PowerSupplys")]
    [ApiController]
    public class PowerSupplysController : ControllerBase
    {
        private ComputerRepo repo { get; }

        public PowerSupplysController(ComputerRepo _repo)
        {
            repo = _repo;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<List<PowerSupply>> GetPowerSupplys()
        {

            return repo.GetPowerSupplys();
        }

        // GET api/values/5
        [HttpGet("{name}", Name = "GetPowerSupplyByName")]
        public ActionResult<PowerSupply> GetPowerSupplyByName(string name)
        {

            return repo.GetPowerSupplyByName(name);
        }
    }
}
