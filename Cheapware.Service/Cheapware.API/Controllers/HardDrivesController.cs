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
    [Route("api/HardDrives")]
    [ApiController]
    [Authorize]
    public class HardDrivesController : ControllerBase
    {
        // GET: api/HardDrives
        private ComputerRepo repo { get; }

        public HardDrivesController(ComputerRepo _repo)
        {
            repo = _repo;
        }
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<List<HardDrive>>> GetHardDrives()
        {

            return await repo.GetHardDrives();
        }

        // GET api/values/5
        [HttpGet("{name}", Name = "GetHardDriveByName")]
        public async Task<ActionResult<HardDrive>> GetHardDriveByName(string name)
        {
            return await repo.GetHardDriveByName(name);
        }

    }
}
