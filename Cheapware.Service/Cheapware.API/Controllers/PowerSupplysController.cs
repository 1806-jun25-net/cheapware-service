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
    [Route("api/PowerSupplys")]
    [ApiController]
    [Authorize]
    public class PowerSupplysController : ControllerBase
    {
        private ComputerRepo repo { get; }

        public PowerSupplysController(ComputerRepo _repo)
        {
            repo = _repo;
        }
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<List<PowerSupply>>> GetPowerSupplys()
        {

            return await repo.GetPowerSupplys();
        }

        // GET api/values/5
        [HttpGet("{name}", Name = "GetPowerSupplyByName")]
        public async Task<ActionResult<PowerSupply>> GetPowerSupplyByName(string name)
        {

            return await repo.GetPowerSupplyByName(name);
        }
    }
}
