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
    [Route("api/HardDrives")]
    [ApiController]
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
        public ActionResult<List<HardDrive>> GetAll()
        {

            return repo.GetHardDrives();
        }

        // GET api/values/5
        [HttpGet("{name}", Name = "GetHardDriveByName")]
        public ActionResult<HardDrive> GetHardDriveByName(string name)
        {
            return repo.GetHardDriveByName(name);
        }

    }
}
